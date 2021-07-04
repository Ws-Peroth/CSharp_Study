using System;

namespace 객체지향문법_4_2_캡슐화
{
    class MainClass
    {
        static void Main(string[] args)
        {
            #region 4.2 Encapsulation.cs
            Encapsulation.RunMethod();
            #endregion

            #region 4.2.1 AccessModifier.cs
            UseAccessModifierClaasses.RunMethod();
            #endregion

            #region 4.2.2 InformationHiding.cs
            InformationHiding informationHiding = new InformationHiding();
            informationHiding.RunMethod();
            informationHiding.SetData(5);
            Console.WriteLine("GetData() : " + informationHiding.GetData() + "\n");
            #endregion

            #region 4.2.3 Property.cs
            Property property = new Property();
            property.RunMethod();
            property.Data = 7;
            Console.WriteLine("Data { get{ return data; } } : " + property.Data + "\n");
            #endregion
        }
    }
}
