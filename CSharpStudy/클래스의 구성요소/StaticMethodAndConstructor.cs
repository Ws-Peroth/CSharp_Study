using System;
using System.Collections.Generic;
using System.Text;

namespace 클래스의_구성요소
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
