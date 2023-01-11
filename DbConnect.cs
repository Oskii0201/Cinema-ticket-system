using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Cinema_ticket_system
{
    //klasa połączenia z bazą danych
    public class DbConnect
    {
                                                                                                           /* ścieżka do pliku z bazą danych Cienema.mdf */
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\oskar\source\repos\Oskii0201\Cinema-ticket-system\Cinema.mdf;Integrated Security=True;Connect Timeout=30");
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader dr;
    }
}