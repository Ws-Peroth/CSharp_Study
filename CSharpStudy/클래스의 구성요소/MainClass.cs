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

            #region 4.1.5.1_InstanceAndStaticMember
            InstanceAndStaticMember instanceAndStaticMember = new InstanceAndStaticMember();
            instanceAndStaticMember.RunMethod();
            #endregion

            #region 4.1.5.3_StaticMethodAndConstructor
            // 객체생성 (new) 없이 사용 가능한 메소드
            StaticMethodAndConstructor.StaticMethod();
            #endregion

            #region 4.1.6_Namespace
            UseNamespace.CallMethod();
            #endregion

        }
    }
}
