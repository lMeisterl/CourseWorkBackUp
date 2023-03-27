using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_работа
{
    public class chekUser
    {
        public string login { get; set; }
        public  bool IsAdmin { get; }

        public string status => IsAdmin ? "Admin" : "User";

        public chekUser(string login, bool isAdmin) 
        {
            login = login.Trim();
            IsAdmin = isAdmin;
        }
    }
}
