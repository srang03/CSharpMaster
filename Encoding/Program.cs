using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Encoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var origin = DateTime.Now;
            var dateTime = origin.ToBinary();
            var bytes = System.Text.Encoding.Unicode.GetBytes(dateTime.ToString());
            var salt = Convert.ToBase64String(bytes);

            var res = Convert.FromBase64String(salt);
            var res2 = System.Text.Encoding.Unicode.GetString(res);

            var res3 = long.Parse(res2);
            var amp = DateTime.FromBinary(res3);
        }
    }
}
