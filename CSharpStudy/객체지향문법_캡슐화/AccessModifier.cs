using System;
using System.Collections.Generic;
using System.Text;

namespace 객체지향문법_4_2_캡슐화
{
    public class UseAccessModifierClaasses
    {
        public static void RunMethod()
        {
            Console.WriteLine("접근 제한자와 특징");
            Console.WriteLine("기본 class : Public, Private 사용 가능");
            Console.WriteLine("중첩 class : Public, Private, Protected, Internal, Internal Protected 사용가능");
            Console.WriteLine();

            AccessModifierClaasses.PublicClass publicClass = new AccessModifierClaasses.PublicClass();
            AccessModifierClaasses.InternalClass internalClass = new AccessModifierClaasses.InternalClass();

            publicClass.PrintClass();
            internalClass.PrintClass();

            AccessModifierClaasses.InaccessibleClass();
        }
    }
}
