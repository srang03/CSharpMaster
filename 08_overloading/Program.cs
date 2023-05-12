namespace _08_overloading
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Overloading overloading_1 = new Overloading("Hi", 10);
            Overloading overloading_2 = new Overloading("Bye", 2);

            var res = overloading_1 * overloading_2;
        }
    }
    class Overloading
    {
        string name;
        int number;
        public Overloading(string strName, int iNumber)
        {
            name = strName;
            number = iNumber;
        }

        public static int operator *(Overloading o1, Overloading o2)
        {
            return o1.number * o2.number;
        }
    }
}