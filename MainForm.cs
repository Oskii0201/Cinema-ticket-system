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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        //sekcja otwarcia ChildForm w MainForm
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        /*Funkcja do załadowania hildform
         * openChildForm(new FormName());
         */
        //koniec sekcji otwarcia hildform w mainform

        private void LoginButton_Click(object sender, EventArgs e)
        {
            openChildForm(new UserSingInForm());
            
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            openChildForm(new UserSingUpForm());
        }

    }
}
