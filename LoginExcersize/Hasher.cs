using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace LoginExcersize
{
    internal class Hasher
    {

        public string HashSHA256(string s)
        {
            string hashedstring = "";
            byte[] bytes = Encoding.UTF8.GetBytes(s);
            SHA256 hash = SHA256Managed.Create();

            byte[] hashbytes = hash.ComputeHash(bytes);
            foreach (var item in hashbytes)
            {
                hashedstring += item.ToString("x2"); 
            }
            return hashedstring;

        }
    }
}
