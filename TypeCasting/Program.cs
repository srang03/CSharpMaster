using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // [1] 암시적 변환 : (double 자료형이 int 자료형보다 크기 때문에 컴파일러가 자동으로 형 변환)
            //int iNumber = 10;
            //double dNumber = iNumber;

            //Button button = new Button();
            //Control control = button;
            //Control control_coin = new Coin();
            //Console.WriteLine(button.GetString());
            //Console.WriteLine(control.GetString());
            //Console.WriteLine(control_coin.GetString());


            // [2] 명시적 변환 : 프로그래머가 직접 강제로 형변환을 수행한다.
            double dNumber = 1.2;
            string strNumber = Convert.ToString(dNumber);


            string str_byte = "300";
            Byte.Parse(str_byte);
            // [3] Boxing: 값 형식을 참조 형식으로 변환
            //object // 참조 변수
            // 값 123을 object라는 참조 형식에 담는 것
            object obj = 123;

            // [4] Unboxing: 참조 형식을 값 형식으로 변환
            // 참조 형식인 object에 있는 것을 값 형식으로 변환
            int i = (int)obj; // Unboxing

            // 참조 형식으로 변환하기 때문에 추가적인 메모리 할당 및 복사 작업이 필요하여 성능에 부담을 줄 수 있는 작업입니다.
            BoxingUnboxing(new Control());

            Console.ReadKey();
        }

        static void BoxingUnboxing(object obj)
        {
            // as연산자는 참조형식을 다른 참조 형식으로 변환할 때 사용하는 연산자
            Button button = obj as Button; // Button Type이 맞다면, 아니면 null 값

            if(button != null)
            {
                Console.WriteLine(button.GetString());
            }
            else
            {
                Console.WriteLine("Button is Null");
            }
          
        }
   
    }
    // Convert, Parse, TryParse

  

    class Control
    {
        public virtual string GetString() => "Control";
    }

    class Button: Control
    {
        public override string GetString() => string.Concat(base.GetString(), "in Button");
    }
    
    class Coin: Control
    {
        public override string GetString()
        {
            return string.Concat(base.GetString(), "in Coin");
        }
    }


}
