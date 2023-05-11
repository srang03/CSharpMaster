using System.Runtime.CompilerServices;

namespace _06_static_access
{
    // 클래스의 일반 맴버 변수는 객체를 생성해야 메모리에 할당된다.

    // 클래스의 스택틱 변수는 객체 생성 이전에 접근할 수 있다.
    // 즉 객체 생성없이 클래스명으로 바로 접근이 가능하다.

    // Static 장점
    // 1) 메모리 측면에서 효율 적일 수 있다. Static 메모리 영역에 저장되어 고정 메모리 영역을 사용하기 때문에 매번 인스턴스를 생성하며 낭비되는 메모리를 줄일 수 있다.
    // 2) 객체를 생성하지 않고 사용할 수 있어 속도가 빠르다. 클래스가 메모리에 올라기는 시점에 생성되므로 바로 사용이 가능해 속도가 빠르다.

    // Static 단점
    // 프로그램 종료시까지 메모리 할당된다. Static 영역은 GC의 관리를 받지 않기 때문에, 프로그램 종료시까지 메모리에 존재한다.
    // 객체 지향적이지 못하다. Static은 따로 객체를 생성하지 않고 Static 영역에 할당된 곳에서 여러 클래스들이 데이터를 불러온다.
    // 이러한 특징은 객체의 데이터들이 캡슐화 되어야 한다는 객체 지향 프로그래밍 원칙을 위반한다.
    // Static 메서드는 인터페이스를 구현하는데 사용할 수 없다. 코드의 재사용성을 높여주는 인터페이스 사용을 방해한다.

    public class Program
    {
        static void Main(string[] args)
        {

            // [1] Access 예제
            // 클래스 명으로 접근이 가능
            Access.code = 10; // 객체 생성을 하지 않아도 프로그램이 시작되면 이미 메모리에 할당되어 있다.

            Access access = new Access();
            access.num = 1; // 일반 맴버 변수의 경우 별도로 메모리를 할당한 뒤에 접근이 가능하다.

            Console.WriteLine(Access.code);
            Console.WriteLine(access.num);

            // [2] Cooking 예제

            // 스태틱 변수
            // 클래스를 통해서 접근
            Cooking.dish = "ready for dish";

            // 일반 변수
            // 객체를 통해서 접근
            Cooking cooking = new Cooking();
            cooking.menu = "ready for menu";
        }
    }

    public class Access
    {
        public static int code = 0;
        public int num = 0;
    }

    public class Cooking
    {
        public static string dish = string.Empty; // 메모리에 미리 할당 (사전 준비)
        public string menu = string.Empty; // 주문 (호출)이 있을 때 사용
    }
}