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
    public partial class UserSingUpForm : Form
    {

        UserManage userManage = new UserManage();

        public UserSingUpForm()
        {
            InitializeComponent();
        }

        private void SingUpButton_Click(object sender, EventArgs e)
        {
            try
            {
                userManage.AddUser(LogInTextBox.Text, PasswordTextBox.Text, MailTextBox.Text, NameTextBox.Text, LastNameTextBox.Text);

                MessageBox.Show("Rejestracja przebiegła pomyślnie");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
