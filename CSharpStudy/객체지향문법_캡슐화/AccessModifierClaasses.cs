using System;
using System.Collections.Generic;
using System.Text;

namespace 객체지향문법_4_2_캡슐화
{
    public class AccessModifierClaasses
    {
        public static void InaccessibleClass()
        {
            PrivateClass privateClass = new PrivateClass();
            PrivateClass2 privateClass2 = new PrivateClass2();
            ProtectedClass protectedClass = new ProtectedClass();

            privateClass.PrintClass();
            privateClass2.PrintClass();
            protectedClass.PrintClass();
        }

        class PrivateClass
        {
            // 내부에서만 접근 가능
            public void PrintClass()
            {
                Console.WriteLine("[class PrivateClass]");
                Console.WriteLine("내부에서만 접근 가능");
                Console.WriteLine();
            }
        }

        private class PrivateClass2
        {
            // 내부에서만 접근 가능
            public void PrintClass()
            {
                Console.WriteLine("[private class PrivateClass2]");
                Console.WriteLine("내부에서만 접근 가능");
                Console.WriteLine();
            }
        }

        protected class ProtectedClass
        {
            // 내부와 파생클래스(상속)에서 접근 가능
            public void PrintClass()
            {
                Console.WriteLine("[protected class ProtectedClass]");
                Console.WriteLine("내부와 파생클래스(상속)에서 접근 가능");
                Console.WriteLine();
            }
        }

        public class PublicClass
        {
            // 외부에서 접근 가능
            public void PrintClass()
            {
                Console.WriteLine("[public class PublicClass]");
                Console.WriteLine("외부에서 접근 가능");
                Console.WriteLine();
            }
        }

        internal class InternalClass
        {
            // 동일한 어셈블리(실행파일)내에서 public에 준하는 접근 제한.
            // 타 어셈블리에서는 접근 불가능
            public void PrintClass()
            {
                Console.WriteLine("[internal class InternalClass]");
                Console.WriteLine("동일한 어셈블리(실행파일)내에서 public에 준하는 접근 제한.");
                Console.WriteLine("타 어셈블리에서는 접근 불가능");
                Console.WriteLine();
            }
        }
    }
}
