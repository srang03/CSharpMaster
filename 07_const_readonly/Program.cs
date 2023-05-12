namespace _07_const_readonly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReadOnly.STATIC_CODE); 

            ReadOnly readOnly = new ReadOnly();
            Console.WriteLine(readOnly.NORMAL_CODE);
        }

    }

    public class ReadOnly
    {
        public readonly static double STATIC_CODE;
        public readonly double NORMAL_CODE;
        public static double CODE;


        public ReadOnly()
        {
            // STATIC_CODE = 20;
            NORMAL_CODE = 10;
            CODE = 10;
        }

        static ReadOnly()
        {
            STATIC_CODE = 20;
            // NORMAL_CODE = 10;
            CODE = 20;
        }
    }
}