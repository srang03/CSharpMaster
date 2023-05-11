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
            Father f = new Father();
            Console.WriteLine(f.GetProperty()); 

            Daughter d = new Daughter();
            Console.WriteLine(d.GetProperty());
            Console.WriteLine(d.GetFaterProperty());
        }
    }

    class GrandFather
    {
        public int GetProperty()
        {
            return 1000;
        }
    }
    class Father: GrandFather
    {
        public int GetFaterProperty()
        {
            return 100;
        }
    }

    class Daughter: Father
    {
        public int GetDaughterProperty()
        {
            return 0;
        }
    }
    

}
