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
        

            public User()
        {

        }

        //Methods

        

        //Properties
        public string UserName
        {
            get { return username; }
            set
            {
                NameValidator vali = new NameValidator();
                username = vali.ValidateAsMail(value);
            }
        }

        
        public string Password
        {
            get { return password; }
            set
            {
                Hasher hash = new Hasher();
                if (value.Length < 6) { throw new  ArgumentException("Your password needs to be at least six characters long."); }
                this.password = hash.HashSHA256((value));
            }
        }
      
        
        
    }
}
