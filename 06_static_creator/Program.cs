namespace _06_static_creator
{
    internal class Program
    {
        // static 생성자
        // 생성자를 static 생성자로 선언할 수 있다.
        // 마찬가지로 static 생성자에서는 일반 변수를 사용할 수 없다.

        static void Main(string[] args)
        {
            // static 변수를 호출한 경우에 static 생성자가만 호출된다.
            Access.code = 20;
            Console.WriteLine(Access.code);

            Access access = new Access();
            Console.ReadKey();
        }
    }

    public class Access
    {
        public static int code = 0;
        public  int normalCode = 0;

        // 1. static 생성자 함수
        // 생성자 함수는 return 값이 없는 특별한 함수이다.

        static Access()
        {
            code = 10;
            // normalCode = 20;

            Console.WriteLine("[1] static 생성자 출력");
            Console.WriteLine("{0}", code);
        }

        public Access()
        {
            code = 10;
            normalCode = 20;
            Console.WriteLine("[2] 생성자 출력");
        }
    }
}