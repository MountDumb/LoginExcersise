using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginExcersize
{
    interface IHasher
    {
        string HashSHA256(string s);
    }
}
