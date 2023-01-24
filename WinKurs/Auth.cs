using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinKurs
{
    public partial class Auth : Form
    {
        public string LastAuthUser = "";
        public Database db1; //ссылка на будущую БД
        public Auth()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //"вход"
        {
            if (userAuthSucceess())
            {
                LastAuthUser = LoginBox1.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool userAuthSucceess() //проверка успешности авторизации
        {
            if (incorrectFiledsOnForm())
            {
                MessageBox.Show("Некорректные (пустые?) поля на форме");
                return false;
            }
            if (hasUser(LoginBox1.Text, PasswordBox1.Text))
            {
                return true;
            } else
            {
                MessageBox.Show("Вход невозможен. Неверный логин или пароль");
                return false;
            }
        }
        private bool hasUser(string login, string password) //проверка существования пользователя
        {
            return db1.CheckUser(login, password, false);
        }
        private bool incorrectFiledsOnForm()
        {
            if (isUnCorrectField(LoginBox1.Text) || isUnCorrectField(PasswordBox1.Text))
                return true;
            return false;
        }

        private bool isUnCorrectField(string field)
        {
            if (String.IsNullOrWhiteSpace(field)) //проверка на пустую строку (или только пробелы)
                return true;
            return false;
        }

        private void button2_Click(object sender, EventArgs e) //кнопка "Регистрации"
        {
            var FrmReg = new FormRegistr();
            FrmReg.db1 = this.db1; //передали в форму регистрации ссылку на открытую ДБ
            var regDialogResult = FrmReg.ShowDialog();
            if (regDialogResult == DialogResult.OK)
            {
                LastAuthUser = FrmReg.LastRegUser;
                this.DialogResult = DialogResult.OK;
                this.Close(); //закрытие формы авторизации после успешной регистрации
            }
        }


        private void button_checkP_Click(object sender, EventArgs e)
        {//обработка события при нажатии на кнопку показать/скрыть пароль
            if (PasswordBox1.PasswordChar == '*')
            {
                PasswordBox1.PasswordChar = '\0';
            } else
            {
                PasswordBox1.PasswordChar = '*';
            }

        }
    }
}
