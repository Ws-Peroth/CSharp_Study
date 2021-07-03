using System;

namespace 객체지향문법_4_2_캡슐화
{
    class MainClass
    {
        static void Main(string[] args)
        {
            #region 4.2_Encapsulation.cs
            Encapsulation.RunMethod();
            #endregion

            #region 4.2.1 AccessModifier
            UseAccessModifierClaasses.RunMethod();
            #endregion

            #region 4.2.2 InformationHiding
            InformationHiding informationHiding = new InformationHiding();
            informationHiding.RunMethod();
            informationHiding.SetData(5);
            Console.WriteLine("GetData() : " + informationHiding.GetData() + "\n");
            #endregion

            #region 4.2.3 Property
            #endregion
        }
    }
}
