using System;

namespace 클래스의_구성요소 
{
    
    public class MainClass
    {
        static void Main(string[] args)
        {
            #region 4.1.4_ClassInfo
            ClassInfo classinfo = new ClassInfo(1234, "Hello");
            classinfo.Method(1);
            #endregion

            #region 4.1.5_InstanceAndStaticMember
            InstanceAndStaticMember instanceAndStaticMember = new InstanceAndStaticMember();
            instanceAndStaticMember.RunMethod();
            #endregion
        }
    }
}
