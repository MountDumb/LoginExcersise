using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace LoginExcersize
{
    internal class Hasher : IHasher
    {

        public string HashSHA256(string s)
        {
            string outputstring = "";
            SHA256 hash = SHA256.Create();

            byte[] inputbytes = Encoding.UTF8.GetBytes(s);            
            byte[] hashbytes = hash.ComputeHash(inputbytes);

            foreach (byte characterrepresentedasbyte in hashbytes)
            {
                //converts byte to string, written as Hexadecimal. "x2" means "Hexadecimal with two digits."
                //two digits are enough because four bits equal one digit of hexadecimal. 
                //2 * 2 * 2 * 2 = 16, as does the count of {1, 2, 3, 4, 5, 6, 7, 8 ,9, 0, a, b, c, d, e, f} 
                outputstring += characterrepresentedasbyte.ToString("x2"); 
            }

            return outputstring;
        }
    }
}
