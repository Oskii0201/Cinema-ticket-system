using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_ticket_system
{
    public partial class UserSingInForm : Form
    {
        public ProgramManage ProgramManage;
        UserManage userManage = new UserManage();

        public UserSingInForm()
        {
            InitializeComponent();
        }

        //akcja logowania
        private void SingInButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                userManage.LogIn(LogintextBox.Text, PasswordTextBox.Text);
                if (userManage.isLogged)
                {
                    MessageBox.Show("Logowanie przebiegło pomyślnie");
                    ProgramManage.CloseLoginForm();
                }
                else
                {
                    MessageBox.Show("Błąd logowania, sprawdź dane");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        //przełączenie ukrycia hasła
        private void ShowPasswordBox_CheckedChanged(object sender, EventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = ShowPasswordBox.Checked ? false : true;
        }

        //akcja ukrycia panelu logowania i pokazania panelu rejestracji
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegistrationPanel.Show();
            LoginPanel.Hide();
        }

        //akcja rejestracji uzytkownika
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                userManage.AddUser(LoginTextBoxR.Text, PasswordTextBoxR.Text, MailTextBoxR.Text, NameTextBoxR.Text, LastNameTextBoxR.Text);

                MessageBox.Show("Rejestracja przebiegła pomyślnie");

                RegistrationPanel.Hide();
                LoginPanel.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
