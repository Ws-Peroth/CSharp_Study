using System;
using System.Collections.Generic;
using System.Text;

namespace 객체지향문법_4_3_상속
{
    public class Inheritance
    {
        public static void RunMethod()
        {
            Console.WriteLine("[상속 사용 예시]");
            Console.WriteLine();
            PC pc = new PC();
            Laptop laptop = new Laptop();

            Console.Write("PC : ");
            pc.TurnOn();
            Console.Write("Laptop : ");
            laptop.TurnOn();
            Console.WriteLine();

            pc.UseMouse();
            laptop.UseTouchPad();
            Console.WriteLine();

            Console.Write("PC : ");
            pc.TurnOff();
            Console.Write("Laptop : ");
            laptop.TurnOff();
            Console.WriteLine();
        }
    }
    public class Computer
    {
        private bool power = false;

        public void TurnOn() 
        { 
            power = true;
            Console.WriteLine("전원을 켭니다.");
        }

        public void TurnOff() 
        { 
            power = false;
            Console.WriteLine("전원을 끕니다.");
        }
    }

    public class PC : Computer
    {
        public void UseMouse()
        {
            Console.WriteLine("PC : 마우스 사용");
        }
    }

    public class Laptop : Computer
    {
        public void UseTouchPad()
        {
            Console.WriteLine("Laptop : 마우스 + 터치패드 사용");
        }
    }
}
