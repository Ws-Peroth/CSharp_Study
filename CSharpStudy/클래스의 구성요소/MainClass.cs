using System;

namespace 객체지향문법 
{

    public class MainClass
    {
        static void Main(string[] args)
        {
            #region 4.1.4_ClassInfo.cs
            ClassInfo classinfo = new ClassInfo(1234, "Hello");
            classinfo.Method(1);
            #endregion

            #region 4.1.5.1_InstanceAndStaticMember.cs
            InstanceAndStaticMember instanceAndStaticMember = new InstanceAndStaticMember();
            instanceAndStaticMember.RunMethod();
            #endregion

            #region 4.1.5.3_StaticMethodAndConstructor.cs
            // 객체생성 (new) 없이 사용 가능한 메소드
            StaticMethodAndConstructor.StaticMethod();
            #endregion

            #region 4.1.6_Namespace.cs
            UseNamespace.CallMethod();
            #endregion

            #region 4.2_Encapsulation.cs
            Encapsulation.RunMethod();
            #endregion
        }
    }
}
