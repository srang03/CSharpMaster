using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ClassVSStruct
{
    public class Program
    {
        static void Main(string[] args)
        {
            GrandFather gf;
            Console.WriteLine(gf.Property()); 
            Console.ReadKey();
        }
    }

    struct GrandFather
    {
        public int Property()
        {
            return 1000;
        }
    }
    struct Father
    {
        public int Property()
        {
            return 100;
        }

    }

    struct Daughter
    {
        public int Property()
        {
            return 0;
        }
    }

}
