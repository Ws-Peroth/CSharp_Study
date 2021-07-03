using System;
using System.Collections.Generic;
using System.Text;

namespace 객체지향문법_4_1_클래스
{
    class StaticMethodAndConstructor
    {
        static int data;

        static StaticMethodAndConstructor()
        {
            Console.WriteLine("[정적 생성자]");
            Console.WriteLine("정적 필드 초기화");
            data = 10;
        }

        public static void StaticMethod()
        {
            Console.WriteLine("[정적 메소드]");
            Console.WriteLine("data : " + data);
            Console.WriteLine("\n");

        }
    }
}
