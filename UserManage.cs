using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cinema_ticket_system
{
    public class UserManage : DbConnect, UserManageI
    {
        public bool isLogged;
        public void AddUser(string login, string password, string mail, string name, string last_name)
        {
                cmd = new SqlCommand("INSERT INTO " +
                        "users(login, password, mail, name, last_name) " +
                        "VALUES(@login, @password, @mail, @name, @last_name)", con);

                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@mail", mail);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@last_name", last_name);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
        }

        public void LogIn(string login, string password)
        {
            cmd = new SqlCommand("SELECT * FROM users WHERE login=@login AND password=@password", con);

            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@password", password);

            con.Open();
            dr = cmd.ExecuteReader();
            dr.Read();

            isLogged = dr.HasRows;

            con.Close();
        }
    }
}