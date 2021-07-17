using System;
using System.Collections.Generic;
using System.Text;

namespace 객체지향문법_4_3_상속
{
    public class Equals_class
    {
        public static void RunMethod()
        {
            int a = 5;
            int b = 5;

            Console.WriteLine("값 형식 : 값을 비교함");
            Console.WriteLine("int a = 5 : " + a);
            Console.WriteLine("int b = 5 : " + b);
            Console.WriteLine("a.Equals(b) : " + a.Equals(b));
            Console.WriteLine();

            b = 10;
            a.Equals(b);
            Console.WriteLine("int a = 5 : " + a);
            Console.WriteLine("int b = 10 : " + b);
            Console.WriteLine("a.Equals(b) : " + a.Equals(b));
            Console.WriteLine();
            Console.WriteLine();

            CompA ca1 = new CompA(10);
            CompA ca2 = new CompA(10);
            Console.WriteLine("참조 타입 : 메모리의 위치를 비교함");
            Console.WriteLine("CompA ca1 = new CompA(10) : " + ca1.data);
            Console.WriteLine("CompA ca2 = new CompA(10) : " + ca2.data);
            Console.WriteLine("ca1.Equals(ca2) : " + ca1.Equals(ca2));
            Console.WriteLine();

            CompB cb1 = new CompB(5);
            CompB cb2 = new CompB(5);
            Console.WriteLine("Equals 메소드를 재정의 하여 참조타입이지만 값을 비교하도록 설정");
            Console.WriteLine("CompB ca1 = new CompB(10) : " + cb1.data);
            Console.WriteLine("CompB ca2 = new CompB(10) : " + cb2.data);
            Console.WriteLine("cb1.Equals(cb2) : " + cb1.Equals(cb2));
            Console.WriteLine();

            string strCo = new string("Compare");
            string strCo2 = new string("Compare");

            Console.WriteLine("string 참조타입 => Equals 메소드를 재정의 해두어서 Equals메소드를 위와같이 재정이 하지 않아도, 자동으로 값끼리 비교하도록 되어있음");
            Console.WriteLine("string strCo = new string(\"Compare\") : " + strCo);
            Console.WriteLine("string strCo2 = new string(\"Compare\") : " + strCo2);
            Console.WriteLine("strCo.Equals(strCo2) : " + strCo.Equals(strCo2));
            Console.WriteLine();

        }
        public class CompA
        {
            public int data;
            public CompA(int data) { this.data = data; }
        }
        public class CompB
        {
            public int data;
            public CompB(int data) { this.data = data; }

            public override int GetHashCode()
            {
                return data;
            }

            public override bool Equals(object obj)
            {
                if (obj is CompB comp)
                {
                    if (this.GetHashCode() == comp.GetHashCode())
                        return true;
                }
                return false;
            }
        }
    }
}
