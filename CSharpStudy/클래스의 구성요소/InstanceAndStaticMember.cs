using System;
using System.Collections.Generic;
using System.Text;

namespace 객체지향문법_4_1_클래스
{
    public class InstanceAndStaticMember
    {
        public void RunMethod()
        {
            InstanceFieldClass a = new InstanceFieldClass();
            InstanceFieldClass b = new InstanceFieldClass();
            InstanceFieldClass c = new InstanceFieldClass();

            Console.WriteLine("인스턴스 필드");
            Console.WriteLine("a.CreatCount : " + a.GetCount());
            Console.WriteLine("b.CreatCount : " + b.GetCount());
            Console.WriteLine("c.CreatCount : " + c.GetCount());


            StaticFieldClass d = new StaticFieldClass();
            StaticFieldClass e = new StaticFieldClass();
            StaticFieldClass f = new StaticFieldClass();

            Console.WriteLine("정적 필드");
            Console.WriteLine("d.CreatCount : " + d.GetCount());
            Console.WriteLine("e.CreatCount : " + e.GetCount());
            Console.WriteLine("f.CreatCount : " + f.GetCount());
            Console.WriteLine("\n");
        }
    }

    public class InstanceFieldClass
    {
        private int creatCount = 0;

        public InstanceFieldClass()
        { creatCount++; }

        public int GetCount() => creatCount;
    }

    public class StaticFieldClass
    {
        static int creatCount = 0;

        public StaticFieldClass()
        { creatCount++; }

        public int GetCount() => creatCount;
    }
}
