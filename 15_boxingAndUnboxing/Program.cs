using System.Collections;

namespace _15_boxingAndUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(1); // 값타입인 정수가 참조 객체 (object)으로 박싱이 된 후 전달된다.
            list.Add(3.141592); // 값타입인 실수가 참조 객체 (object)으로 박싱이 된 후 전달된다.
            list.Add("Hi"); // 참조 타입은 참조
        }
    }
}