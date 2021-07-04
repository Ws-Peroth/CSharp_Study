using System;
using System.Collections.Generic;
using System.Text;

namespace 객체지향문법_4_3_상속
{
    class AsAndIs
    {
        public static void RunMethod()
        {
            Console.WriteLine("[as, is 연산자]");
            Console.WriteLine("A a = new A()");
            Console.WriteLine("B b = a as B");
            A a = new A();
            B b = a as B;   // 인스턴스 반환
            if (b != null) b.PrintB();
            else Console.WriteLine("명시적 캐스팅 불가능 [ b = null ]");
            Console.WriteLine();

            Console.WriteLine("[as, is 연산자]");
            Console.WriteLine("A a2 = new A()");
            Console.WriteLine("bool isPossible = a2 is B b2;");
            A a2 = new A();
            bool isPossible = a2 is B b2;   // bool 반환
            Console.WriteLine("명시적 캐스팅 가능 여부 : " + isPossible);
            Console.WriteLine("as와 is는 모두 \"참조타입\"과 \"값 형식\" 으로만 사용가능");
        }

    }
}
