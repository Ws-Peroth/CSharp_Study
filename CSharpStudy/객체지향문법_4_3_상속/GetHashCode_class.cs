using System;
using System.Collections.Generic;
using System.Text;

namespace 객체지향문법_4_3_상속
{
    class GetHashCode_class
    {
        public static void RunMethod()
        {
            Console.WriteLine("GetHashCode() 메서드");
            Console.WriteLine("인스턴스의 특정 고유 값을 int형으로 반환 해줌.");
            Console.WriteLine("Equals 메서드를 사용 할 경우 재정의를 해 주어야 하며, GetHashCode()의 결과값이 같으면 Equals()의 결과도 true, GetHashCode()의 결과값이 다르면 Equals()의 결과도 false여야 한다.");
            Console.WriteLine();

            HashA data1 = new HashA(10);
            HashA data2 = new HashA(10);

            Console.WriteLine($"HashA data1 = new HashA(10) : {data1.data}");
            Console.WriteLine($"HashA data2 = new HashA(10) : {data2.data}");
            Console.WriteLine();

            Console.WriteLine($"data1.GetHashCode() : {data1.GetHashCode()}");
            Console.WriteLine($"data2.GetHashCode() : {data2.GetHashCode()}");
            Console.WriteLine();

            int num1 = 123;
            int num2 = 4567890;

            Console.WriteLine($"int num1 = 123 : {num1}");
            Console.WriteLine($"int num2 = 4567890 : {num2}");
            Console.WriteLine();

            Console.WriteLine($"num1.GetHashCode() = value : {num1.GetHashCode()} = {num1}");
            Console.WriteLine($"str2.GetHashCode() = value : {num2.GetHashCode()} = {num2}");
        }

        public class HashA
        {
            public int data;

            public HashA(int data)
            {
                this.data = data;
            }
        }
    }
}
