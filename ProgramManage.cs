using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_ticket_system
{
    public class ProgramManage
    {
        private UserSingInForm LoginForm;
        private bool click = false;
        public void Run()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm = new UserSingInForm();
            LoginForm.ProgramManage = this;
            Application.Run(LoginForm);
            RunMainForm();
        }

        public void CloseLoginForm()
        {
            click = true;
            LoginForm.Close();
        }
        private void RunMainForm()
        {
            if (click)
            {
                MainForm form = new MainForm();
                form.ShowDialog();
            }

        }
    }
}