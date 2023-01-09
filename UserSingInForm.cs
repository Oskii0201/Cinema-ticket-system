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
        UserManage userManage = new UserManage();

        public UserSingInForm()
        {
            InitializeComponent();
        }

        private void SingInButton_Click(object sender, EventArgs e)
        {
            try
            {
                userManage.LogIn(LogintextBox.Text, PasswordTextBox.Text);
                if (userManage.isLogged)
                {
                    MessageBox.Show("Logowanie przebiegło pomyślnie");
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
    }
}
