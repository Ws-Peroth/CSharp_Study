using System;
using System.Collections.Generic;
using System.Text;

namespace 객체지향문법_4_3_상속
{
    class GetTypeClass
    {
        public static void RunMethod()
        {
            Console.WriteLine("GetType()");
            Console.WriteLine("기본 타입 포함, 프로퍼티를 가져옴");
            Console.WriteLine("Type t = instance.GetType()");
            Data data = new Data();
            Type t = data.GetType();
            Console.WriteLine("Data data = new Data()");
            Console.WriteLine("Type t = data.GetType()");
            Console.WriteLine("t = " + t);
        }
    }
}
