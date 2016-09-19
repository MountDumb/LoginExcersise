using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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

        

        //Properties
        public string UserName
        {
            get { return username; }
            set { username = value; }
        }

        
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
      
        
        
    }
}
