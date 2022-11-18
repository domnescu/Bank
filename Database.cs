using System;
using System.Data.SQLite;

namespace Bank
{
    class Database
    {
        /// подключение локальной базы данных
        /// </summary>
        protected SQLiteConnection DataBase;
        /// <summary>
        /// Объект который будет принимать SQl комманды
        /// </summary>
        protected static SQLiteCommand command;
        public Database()
        {
            DataBase = new SQLiteConnection(string.Format("Data Source=database.db;"));
        }

        public bool Authorize(string _login, string _password)
        {
            DataBase.Open();
            try
            {
                command = new SQLiteCommand("SELECT count(*) FROM Users WHERE Login='" + _login + "' AND Password='" + _password + "';", DataBase);
                int countRows = Convert.ToInt32(command.ExecuteScalar());
                if (countRows == 1)
                {
                    DataBase.Close();
                    return true;
                }
                DataBase.Close();
                return false;
            }
            catch
            {
                DataBase.Close();
                return false;
            }
        }

        public bool LoginIsFree(string _login)
        {
            DataBase.Open();
            try
            {
                command = new SQLiteCommand("SELECT count(*) FROM Users WHERE Login='" + _login + "';", DataBase);
                int countRows = Convert.ToInt32(command.ExecuteScalar());
                if (countRows == 0)
                {
                    DataBase.Close();
                    return true;
                }
            }
            catch
            {
                DataBase.Close();
                return false;
            }
            DataBase.Close();
            return false;
        }

        public bool Register(string _login, string _password, string _FName, string _LName)
        {
            DataBase.Open();
            try
            {
                command = new SQLiteCommand("INSERT INTO Users (FName,LName,Login,Password) VALUES ('" + _FName + "','" + _LName + "','" + _login + "','" + _password + "');", DataBase);
                DataBase.Close();
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                DataBase.Close();
                return false;
            }
        }

        public string GetHistory(string login)
        {
            return "";
        }

        public void UpdateHistory(string _login, string _account, string _count)
        {
        }
        public void CreateAccount(string _login, string _account)
        {
        }
    }
}
