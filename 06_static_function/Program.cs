namespace _06_static_function
{
    // static 함수와 일반 함수 접근 차이

    // static 함수를 이용해서 일반 맴버 필드에 접근이 불가능
    // 이유: 일반 맴버 필드는 객체를 생성한 후에 존재하기 때문에, 객체를 생성하지 않고 사용하는 static 함수에서 일반 맴버 필드 사용 불가능

    internal class Program
    {
        static void Main(string[] args)
        {
            // static 함수 실행 
            Access.Run(); // 프로그램 시작과 동시에 메모리 할당

            // 일반 함수 실행
            Access access = new Access(); // 일반 함수는 메모리에 할당되지 않아 사용할 수 없다. 인스턴스화를 통해 객체를 생성한 후 (메모리에 할당한 후) 일반 함수를 사용할 수 있다.
            access.Task();
        }
    }

    public class Access
    {
        // Static 변수는 프로그램을 시작하면 가장 먼저 메모리에 할당된다.
        public static String code = "[static 변수]"; // static 메모리에 저장
        public string normalCode = "[일반 변수]"; // 일반 변수는 stack 메모리에 저장

        // 1. static 함수
        public static void Run()
        {
            Console.WriteLine(code);
            // Console.WriteLine(normalCode); // 일반 맴버 변수 접근 불가능 (메모리에 할당이 안되어 있으므로)
        }

        // 2. 일반 함수
        // 일반 함수를 사용하기 위해서는 객체를 생성해야한다.
        // 객체를 생성하면 메모리에 할당된다.
        // 객체가 메모리에 할당되었기 때문에 일반 맴버 변수도 메모리에 할당된다 (스택 영역)
        // 따라서 static 맴버 변수와 일반 변수가 모두를 사용할 수 있게 된다. 
        public void Task()
        {
            Console.WriteLine(code);
            Console.WriteLine(normalCode);
        }
    }
}