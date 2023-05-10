using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetNumber(out int i);
            Console.WriteLine(i);
        }
        

        static void GetNumber(out int number)
        {
            number = 10;
        }
    }
}
