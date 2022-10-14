using System;
using System.Collections.Generic;
using System.Text;

namespace TASK
{
    class Account
    {
        public string Login(string username, string password)
        {
            if (username == "cavid123" && password == "Cavid1993")
            {
                return "Giris Ugurludur";
            }
            else
            {
                return "email ve ya password sehvdir";
            }

        }
    }
}
