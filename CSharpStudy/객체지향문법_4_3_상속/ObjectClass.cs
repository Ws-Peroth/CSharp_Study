using System;
using System.Collections.Generic;
using System.Text;

namespace 객체지향문법_4_3_상속
{
    class ObjectClass
    {
        public static void RunMethod()
        {
            Console.WriteLine("[모든 클래스의 조상 System.Object]");
            Console.WriteLine("System.Object = 클래스 이면서 값(object)]");
            Console.WriteLine();
            Data data = new Data();
            object obj = data;
            Data data1 = obj as Data;

            Console.WriteLine("Data data = new Data()");
            Console.WriteLine("object obj = data");
            Console.WriteLine("Data data1 = obj as Data");
            Console.WriteLine();
        }
    }

    public class Data
    {
        public int data;
    }
}
