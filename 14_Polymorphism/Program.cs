namespace _14_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Benz benz = new Benz();
            benz.Drive();

            Car benzCar = benz;
            benzCar.SuperDrive();
        }
    }

    public class Car
    {
        public void Drive()
        {
            Console.WriteLine("Drive ...");
        }
        public virtual void SuperDrive()
        {
            Console.WriteLine("Drive ...");
        }
    }

    public class Benz : Car
    {
        public new void Drive()
        {
            Console.WriteLine("Benz Drive...");
        }

        public override void SuperDrive()
        {
            Console.WriteLine("Super Drive ...");
        }
        public void BenzDrive()
        {
            Console.WriteLine("");
        }
    }
}