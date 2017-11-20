using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solid_principles.SRP
{
    public class User
    {
        public string Email;
        public string Password;

        public User(string email, string password)
        {
            this.Email = email;
            this.Password = password;
        }
    }
}
