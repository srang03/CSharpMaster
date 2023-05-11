namespace _05_Static
{
    // 일반 변수는 함수 호출이 끝나면 소멸된다.
    // static으로 선언된 변수는 함수 호출이 끝나도 계속 메모리에 남아 있다.

    public class Company
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine();
                Commute worker = new Commute();
                worker.Start();
                Console.WriteLine();
            }
        }
    }

    public class Commute
    {
        static int hours = 0;
        int salary = 0;

        // 생성자 함수 
        public Commute()
        {
            hours += 1;
            salary += 1;
        }

        public void Start()
        {
            Console.WriteLine("hours: {0}", hours);
            Console.WriteLine("salary: {0}", salary);
        }
    }
}