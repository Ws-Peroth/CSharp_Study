using System;
using System.Collections.Generic;
using System.Text;
using 클래스의_구성요소.C;

namespace 클래스의_구성요소
{


    static class UseNamespace
    {
        public static void CallMethod()
        {
            Console.WriteLine("네임스페이스 비교");

            Console.WriteLine("A.A a = new A.A(10)");
            A.A a = new A.A(10);
            a.PrintData();

            Console.WriteLine("B.A a = new B.A(10)");
            B.A b = new B.A(5);
            b.PrintData();
            Console.WriteLine("using 클래스의_구성요소.C");
            Console.WriteLine("ClassC classC = new ClassC(7);");
            ClassC classC = new ClassC(7);
            classC.PrintData();

        }
    } 
    namespace A
    {
        public class A
        {
            int data;
            public A(int data)
            {
                this.data = data;
            }

            public void PrintData()
            {
                Console.WriteLine("[namespace A] class A.data : " + data + "\n");
            }
        }
    }

    namespace B
    {
        public class A
        {
            int data;
            public A(int data)
            {
                this.data = data;
            }

            public void PrintData()
            {
                Console.WriteLine("[namespace B] class A.data : " + data + "\n");
            }
        }
    }

    namespace C
    {
        public class ClassC
        {
            int data;
            public ClassC(int data)
            {
                this.data = data;
            }

            public void PrintData()
            {
                Console.WriteLine("[namespace C] class ClassC.data : " + data + "\n");
            }
        }
    }
}
