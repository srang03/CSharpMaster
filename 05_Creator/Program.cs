namespace _05_Creator
{
    internal class Program
    {
        // 생성자 함수는 메모리에 할당된 이후 가장 먼저 호출되는 특별한 함수이다.
        // 개발자가 생성자 함수를 정의하지 않았다면 컴파일러가 빈 디폴트 생성자를 자동으로 만든다.
        // 개발자가 하나라도 생성자 함수를 정의했다면, 빈 디폴트 생성자는 만들어지지 않는다.

        // 생성자를 통해 함수를 호출시키자 마자 초기화 또는 세팅해주고 싶은 경우가 있다.
        // 그러한 변수 또는 함수를 생성자 함수에 넣을 수 있다.

        static void Main(string[] args)
        {
            Commute c = new Commute();
            c.Work();
            c.Work();
            c.Work();
            
        }
    }

    public class Commute
    {
        int hour;

        // 생성자 함수: 메모리가 할당되면 가장 먼저 1회 실행된다.
        public Commute()
        {
            hour = 8;
            Console.WriteLine("출근 완료");
        }

        // 일반 함수: 호출되면 실행된다.
        public void Work()
        {
            hour -= 1;
            Console.WriteLine("남은 시간: {0}", hour);
        }
    }
    public class Company
    {
      
    }
}