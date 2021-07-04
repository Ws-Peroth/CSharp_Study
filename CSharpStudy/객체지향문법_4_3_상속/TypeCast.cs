using System;
using System.Collections.Generic;
using System.Text;

namespace 객체지향문법_4_3_상속
{
    class TypeCast
    {
        public static void RunMethod()
        {
            Console.WriteLine("[암시적 형변환]");
            Console.WriteLine("short a = 100");
            Console.WriteLine("int b = a");
            short a = 100;
            int b = a;
            Console.WriteLine("a = " + a + ", b = " + b + "\n");

            Console.WriteLine("[명시적 형변환]");
            Console.WriteLine("int c = 100");
            Console.WriteLine("short d = (short)c");
            int c = 100;
            short d = (short)c;
            Console.WriteLine("c = " + c + ", d = " + d + "\n");

            Console.WriteLine("[암시적 형변환]");
            Console.WriteLine("부모 클래스의 인스턴스에 자식 클래스를 대입");
            Console.WriteLine("A classA = new B()");
            A classA = new B();
            Console.Write("[ classA] : data = " + classA.data);
            classA.PrintA();

            Console.WriteLine("[명시적 형변환]");
            Console.WriteLine("자식 클래스의 인스턴스를 부모에 대입");
            Console.WriteLine("B classB = (B)new A()");
            Console.WriteLine("단, 이땐 실행시 Unhandled exception 발생\n");

            Console.WriteLine("다음과 같은 경우에 명시적 변환을 이용 가능");
            Console.WriteLine("B classB = new B()");
            Console.WriteLine(" A classA2 = classB");
            Console.WriteLine("B classB2 = (B)classA2");
            Console.WriteLine("classB2.PrintB()");

            B classB = new B();
            A classA2 = classB; // 암시적 형변환

            B classB2 = (B)classA2; // 명시적 형변환
            classB2.PrintB();
            Console.WriteLine();
        }
    }

    public class A
    {
        public int data = 1;

        public void PrintA() => Console.WriteLine("this is class A");
    }

    public class B : A
    {
        public int data = 2;

        public void PrintB() => Console.WriteLine("this is class B");
    }
}
