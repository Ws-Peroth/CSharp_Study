using System;
using System.Collections.Generic;
using System.Text;

namespace 객체지향문법_4_2_캡슐화
{
    public class Encapsulation
    {
        public static void RunMethod()
        {
            Console.WriteLine("[캡슐화]");
            Circle circle = new Circle();
            Console.WriteLine("필드에 직접 접근을 하지 못하도록 설정");
            circle.SetRadius(5);
            circle.PrintSize();
        }
    }

    public class Circle
    {
        private double pi = 3.14;
        private double radius = 1;

        public void SetRadius(int radius) => this.radius = radius;

        private double GetSize(double radius) => radius * radius * pi;

        public void PrintSize() => Console.WriteLine("Size : " + GetSize(10) + "\n");

    }
}



