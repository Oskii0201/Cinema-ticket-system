using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cinema_ticket_system
{
    public interface UserManageI
    {
        void AddUser(string login, string password, string mail, string name, string last_name);
        void LogIn(string login, string password);
    }
}