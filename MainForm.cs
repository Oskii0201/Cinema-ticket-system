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
        UserManage userManage = new UserManage();

        public MainForm()
        {
            InitializeComponent();
        }

        //sekcja otwarcia ChildForm w MainForm
        private Form activeForm = null;
        public void openChildForm(Form childForm)
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

        private void RepertuarButton_Click(object sender, EventArgs e)
        {

        }
        private void changeUserName()
        {
            //NameLabel.Text = userManage.user[0].ToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            changeUserName();
        }
    }
}
