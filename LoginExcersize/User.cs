using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace LoginExcersize
{
    class User : IUser
    {
        //Fields
        private string username;
        private string password;
        

            public User()
        {

        }

        //Methods

            public string Hasher(string s)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(s);
            SHA256 hash = SHA256Managed.Create();

            byte[] hashedstring = hash.ComputeHash(bytes);
            return hashedstring.ToString();
            
        }

        //Properties
        public string UserName
        {
            get { return username; }
            set { username = value; }
        }

        
        public string Password
        {
            get { return password; }
            set { password = Hasher(value); }
        }
      
        
        
    }
}
