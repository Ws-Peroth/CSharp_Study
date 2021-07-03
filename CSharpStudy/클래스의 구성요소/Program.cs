using System;

namespace 클래스의_구성요소 
{
    
    public class Program
    {
        static void Main(string[] args)
        {
            ClassInfo classinfo = new ClassInfo(1234, "Hello");
            classinfo.Method(1);
            
        }
    }
}
