using System;

namespace 객체지향문법_4_3_상속
{
    class MainClass
    {
        static void Main(string[] args)
        {
            #region 4.3 Inheritance.cs
            Inheritance.RunMethod();
            #endregion

            #region 4.3.1 TypeCast.cs
            TypeCast.RunMethod();
            #endregion

            #region 4.3.1 AsAndIs.cs
            AsAndIs.RunMethod();
            #endregion

            #region 4.3.2 ObjectClass.cs
            ObjectClass.RunMethod();
            #endregion

            #region 4.3.2.1 ToStringClass.cs
            ToStringClass.RunMethod();
            #endregion

            #region 4.3.2.2 GetTypeClass.cs
            GetTypeClass.RunMethod();
            #endregion

            Console.WriteLine("\n\n\n");

            #region 4.3.2.3 Equals_class.cs
            Equals_class.RunMethod();
            #endregion

            #region 4.3.2.4 GetHashCode_class.cs
            GetHashCode_class.RunMethod();
            #endregion

            #region 4.3.3 GetHashCode_class.cs
            Array_class.RunMethod();
            #endregion
        }
    }
}
