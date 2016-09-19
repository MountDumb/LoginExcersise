using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LoginExcersize
{
    internal class NameValidator
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
                    else { throw new Exception("Invalid Email address"); }
                }
            }            
            throw new Exception("Invalid Email address");
        }
    }
}
