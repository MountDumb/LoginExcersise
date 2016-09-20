using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq; 

namespace LoginExcersize
{
    internal class NameValidator: INameValidator
    {
        public string ValidateAsMail(string s)
        {
            char[] testarray = s.ToCharArray();

            if (!testarray.Contains(';') && !testarray.Contains(' '))
            {                
                for (int i = 0; i < testarray.Length; i++)
                {
                    if (testarray[i] == '@')
                    {
                        for (int ii = i + 1; ii < testarray.Length; ii++)
                        {
                            if (testarray[ii] == '.')
                            {
                                return s;
                            }
                        }
                    }
                    
                 }
            }            
            throw new Exception("Invalid Email address");
        }
    }
}
