namespace _09_This
{
    internal class Program
    {
        static void Main(string[] args)
        {
            This t = new This();
        }
    }

    class This
    {
        int iNumber = 0;

        public This(): this(1)
        {
            Console.WriteLine("매개변수 없음");
        }
        public This(int iNumber): this(10, 20)
        {
            Console.WriteLine($"매개변수 1개 {iNumber}");
        }
        public This(int iNumber1, int iNumber2)
        {
            Console.WriteLine($"매개변수 2개 {iNumber1}, {iNumber2}");
        }
    }
}