using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LoginExcersize
{
    internal class User : IUser
    {
        //Fields
        private string username;
        private string password;
        private IHasher hash;
        INameValidator vali;

            public User(IHasher hash, INameValidator vali)
        {
            this.hash = hash;
            this.vali = vali;
        }

        //Methods

        

        //Properties
        public string UserName
        {
            get { return username; }
            set
            {
                username = vali.ValidateAsMail(value);
            }
        }

        
        public string Password
        {
            get { return password; }
            set
            {
                 if (value.Length < 6) { throw new  ArgumentException("Your password needs to be at least six characters long."); }
                this.password = hash.HashSHA256((value));
            }
        }
      
        
        
    }
}
