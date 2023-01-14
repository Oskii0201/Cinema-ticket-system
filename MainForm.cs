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
        public string[] userr = new string[6];
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
            openChildForm(new RepertuarForm());
        }
        private void changeUserName()
        {
            NameLabel.Text = userr[0].ToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            changeUserName();
        }
    }
}
