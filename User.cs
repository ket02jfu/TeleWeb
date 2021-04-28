using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teleWeb2
{
    class User
    {
        public int id { get; set; }
        private string login, email, password, message;
        public string Login { 
            get { return login; } 
            set { login = value; } 
        }
        public string Email {
            get { return email; } 
            set { email = value; }
        }
        public string Password{ 
            get { return password; }
            set { password = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        
        public User(){ }
        public User(string login, string email, string password, string message)
        {
            this.login = login;
            this.email = email;
            this.password = password;
            this.message = message;
        }

        public User(string login, string email, string password)
        {
            this.login = login;
            this.email = email;
            this.password = password;
        }

        /*public override string ToString()
        {
            return "Сообщение: " + Message;
        }*/


    }
}
