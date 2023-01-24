using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinKurs
{
    public partial class FormRegistr : Form
    {
        public string LastRegUser = "";
        public Database db1;
        public FormRegistr()
        {
            InitializeComponent();
        }

        private void Button_Reg_Click(object sender, EventArgs e)
        {
            bool hasCif = false; //есть ли цифры
            bool hasAlp = false; //есть ли латинские буквы
            for (int i = 0; i < PassB1.Text.Length; i++)
            {
                hasCif = hasCif || ((PassB1.Text[i] >= '0') && (PassB1.Text[i] <= '9'));
                hasAlp = hasAlp || ((PassB1.Text[i] >= 'a') && (PassB1.Text[i] <= 'z')) ||
                    ((PassB1.Text[i] >= 'A') && (PassB1.Text[i] <= 'Z'));
            }
            //Получили: есть или нет цифры, есть или нет латинские буквы (отдельными 2-мя переменными)


            if (String.IsNullOrWhiteSpace(LoginB.Text) ||
                String.IsNullOrWhiteSpace(PassB1.Text) ||
                String.IsNullOrWhiteSpace(PassB2.Text))
            {
                MessageBox.Show("Есть неверные (пустые?) поля");
                return;
            } else if (PassB1.Text.Length < 8)
            {
                MessageBox.Show("Пароль менее 8 символов");
                return;
            } else if (!(hasCif & hasAlp))
            {
                MessageBox.Show("В пароле требуются лат.буквы и цифры");
                return;
            } else if (PassB1.Text != PassB2.Text)
            {
                MessageBox.Show("Два пароля не совпадают");
                return;
            } else 
            {
                if (db1.CheckUser(LoginB.Text, "---", true))
                {
                    MessageBox.Show("Такой пользователь уже зарегистрирован - выберите другой логин");
                    return;
                }
                LastRegUser = LoginB.Text;
                db1.CreateUser(LoginB.Text, PassB1.Text);
                this.DialogResult = DialogResult.OK;
                this.Close(); //закрываем форму регистрации
            }
        }

        private void buttoncheckPP_Click(object sender, EventArgs e)
        {// обработка события при нажатии на кнопку показать/ скрыть пароль
            if (PassB1.PasswordChar == '*')
            {
                PassB1.PasswordChar = '\0';
                PassB2.PasswordChar = '\0';
            }
            else
            {
                PassB1.PasswordChar = '*';
                PassB2.PasswordChar = '*';
            }

        }
    }
}
