namespace _11_Overriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Son son = new Son("test");
 
        }
    }

    class Father
    {
        string name;
        public Father(string name)
        {
            this.name = name;
        }
    }

    class Son: Father
    {
        public Son(string name): base(name)
        {
   
        }
    }
}