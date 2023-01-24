using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinKurs
{
    public partial class FormMain : Form
    {
        public Database myDB;
        public string RegUser;
        public string EncTimeStamp;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            string currentDirectoryPath = Path.GetDirectoryName(Application.ExecutablePath);
            if (!File.Exists($"{currentDirectoryPath}\\dataBase.db"))
            {
                myDB = new Database("Data Source=dataBase.db; Version = 3;"); 
                myDB.InitializeDatabase();
            }
            else
            {
                myDB = new Database("Data Source=dataBase.db; Version = 3;");
            }

            var FrmAuth = new Auth(); //создаём новый экземпляр формы авторизации
            FrmAuth.db1 = myDB;
            DialogResult authDialogResult = FrmAuth.ShowDialog(); 
            if (authDialogResult != DialogResult.OK)
            {
                myDB.CloseDB();
                MessageBox.Show("Вы не авторизовались!");
                this.Close();
            }
            RegUser = FrmAuth.LastAuthUser;
            this.Text = "Шифрование (" + RegUser + ")";
        }

        private void button_code_Click(object sender, EventArgs e)
        {
            int di = (int)DiamEd.Value;
            if (SourceText.Text.Length <= di) //длина текста должна быть больше ключа шифрования
            {
                MessageBox.Show("Короткий текст для шифрования");
                return;
            }
            Scitala sc = new Scitala(di);
            TargetText.Text = sc.Encode(SourceText.Text); // вызов функции шифрования
            DecrText.Text = sc.DecodePure(TargetText.Text); // вызов функции дешифрования для контроля
            //Данные входящие в подсказку: 
            EncTimeStamp = DateTime.Now.ToString();
            EncLabel.Text = RegUser+", "+EncTimeStamp+", Ключ= "+DiamEd.Value.ToString();
            EncrFBox.Text = "(Ещё не сохранён)";
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {//при закрытие основного окна, закрывается база данных
            myDB.CloseDB();
        }

        public void WriteFile() //не вызываем
        { //Запись результата шифрования в файл принудительно
            string s = EncLabel.Text;
            string FName = RegUser + "_"; //FName - имя файла, формируется автоматически
            for (int i = 0; i < s.Length; i++)
            {
                if ((s[i] >= '0') && (s[i] <= '9'))
                {
                    FName += s[i];
                }
            }
            StreamWriter fi = new StreamWriter(FName + ".txt", false);
            fi.WriteLine("{Encoded}");
            fi.WriteLine(TargetText.Text);
            fi.WriteLine(" ");
            fi.WriteLine("{Decoded}");
            fi.WriteLine(DecrText.Text);
            fi.Close();
        }

        public void WriteFile(string FName)
        { //Запись результата шифрования в файл
            StreamWriter fi = new StreamWriter(FName, false);
            EncrFBox.Text = FName;
            fi.WriteLine(EncLabel.Text);           
            fi.WriteLine(TargetText.Text);
            fi.Close();
        }

        private void SaveEncrBut_Click(object sender, EventArgs e)
        {
            if (TargetText.Text.Length > 0) 
            {  //сохранение шифрованного текста
                if (EncrSaveDi.ShowDialog() == DialogResult.OK)
                {
                    WriteFile(EncrSaveDi.FileName); //вызов функции сохр. файла 
                } else
                {
                    return;
                }
            } else
            {
                MessageBox.Show("Текст для сохранения отсутствует");
                return;
            }
        }

        private void EncrOpenBut_Click(object sender, EventArgs e)
        {//обработка события при нажатии на кнопку открыть файл (файл раньше был сохранён)
            if (EncrOpenDi.ShowDialog() == DialogResult.OK)
            {
                StreamReader fi = new StreamReader(EncrOpenDi.FileName);
                EncLabel.Text = fi.ReadLine();
                EncrFBox.Text = EncrOpenDi.FileName;
                TargetText.Text = fi.ReadLine();
                fi.Close();
                SourceText.Text = "";
                Scitala sc = new Scitala(5);
                DecrText.Text = sc.DecodePure(TargetText.Text);
            }
        }

        private void MainCancel_Click(object sender, EventArgs e)
        {//обработка события нажатия кнопки закрыть окно
            Close();
        }

        private void DiamEd_ValueChanged(object sender, EventArgs e)
        {//при изменение значения ключа, есть возможность передешифровать шифрованный текст
            if ((TargetText.Text.Length > 0) && (DecrText.Text.Length > 0))
            {
                Scitala sc = new Scitala((int) DiamEd.Value);
                DecrText.Text = sc.DecodePure(TargetText.Text);
            }
        }
    }
}
