using System;
using System.Collections.Generic;
using System.Text;

namespace 객체지향문법_4_3_상속
{
    public class ToStringClass
    {
        public static void RunMethod()
        {
            Console.WriteLine("[ instance.ToString() ]");
            Console.WriteLine("기본 타입에 대해서는 값을 출력");
            Console.WriteLine("Data data = new Data()");
            Console.WriteLine("data.ToString()");
            Data data = new Data();
            Console.WriteLine(data.ToString());
            Console.WriteLine();
            int d = 100;
            Console.WriteLine("int d = 100");
            Console.WriteLine("d.ToString()");
            Console.WriteLine(d.ToString());
        }
    }
}
