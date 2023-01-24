using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace WinKurs
{
    public class Database
    {
        private readonly string dataSource;
        private SQLiteConnection conn; 

        private static string GenMD5Hash(string user0, string password0)
        { //получение хэша пароля
            byte[] passwordBytes = Encoding.UTF8.GetBytes(user0.ToUpper()+password0);
            byte[] res = new MD5CryptoServiceProvider().ComputeHash(passwordBytes);
            return Convert.ToBase64String(res);
        }

        public Database(string dataSource)
        {
            this.dataSource = dataSource;
            conn = new SQLiteConnection(dataSource); //создаём новый конект к БД с известным источником данных
        }
        public bool InitializeDatabase()
        {//создание БД с нуля
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SQLiteCommand cmd = conn.CreateCommand();
                string sql_command = "CREATE TABLE IF NOT EXISTS users("
                    + "id INTEGER PRIMARY KEY AUTOINCREMENT, "
                    + "login TEXT, "
                    + "password TEXT, "
                    + "role TEXT)";
                cmd.CommandText = sql_command;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e) //Exception - исключение
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }


        public bool CreateUser(string username, string password)
        {//вносим новогопользователя
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format("INSERT INTO users (login, password)"
                + " VALUES ('{0}', '{1}')",
                username.ToUpper(), GenMD5Hash(username, password)); //имя пользователя сохраняется большими буквами (ToUpper)
                cmd.ExecuteNonQuery();                              //в пароль сохраняется значение функции хэша (GenMD5Hash)
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }
            

        public bool CheckUser(string username, string password, bool anypass)
        { //проверка есть ли этот пользователь в базе данных
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SQLiteCommand cmd = conn.CreateCommand();
                if (anypass) //пользователь с любым паролем (не проверяем пароль)
                {
                    cmd.CommandText = string.Format("SELECT login, password, role"
                    + " FROM users"
                    + " where login = '{0}'",
                    username.ToUpper());
                } else
                {
                    cmd.CommandText = string.Format("SELECT login, password, role"
                    + " FROM users"
                    + " where login = '{0}' AND"
                    + " password = '{1}'",
                    username.ToUpper(), GenMD5Hash(username, password));
                }
                return cmd.ExecuteScalar() != null;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public void CloseDB()
        { //закрыть базу в конце работы
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
