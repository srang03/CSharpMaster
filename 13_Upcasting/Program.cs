namespace _13_Upcasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SuperCar superCar = new SuperCar();

            // Interface의 업캐스팅
            InterfaceCar interfaceCar = superCar;

            // abstract의 업캐스팅
            interfaceCar.Drive();
            
            superCar.Drive();
            superCar.TurnOn();

        }
    }

    public abstract class Car { 
        public void TurnOn() { }
    }
    public class Hyndai : Car { }

    public class Benz : Car { }

    public class BMW : Car { }

    public class SuperCar : Car, InterfaceCar
    {
        public void Drive()
        {
            Console.WriteLine("Drive ..");
        }
    }

    public class CarCenter
    {
        // 부모(상위) 클래스 타입으로 인자를 받는다.
        public void Inspection(Car car)
        {
            Console.WriteLine("car Inspection");
        }
        public void InspectionFromInterface(InterfaceCar car)
        {
            Console.WriteLine("car Inspection");
        }
    }


    public interface InterfaceCar
    {
        void Drive();
    }

}