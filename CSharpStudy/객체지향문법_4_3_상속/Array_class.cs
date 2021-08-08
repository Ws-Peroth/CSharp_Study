using System;
using System.Collections.Generic;
using System.Text;

namespace 객체지향문법_4_3_상속
{
    class Array_class
    {
        public static void RunMethod()
        {
            int[] array = new int[] { 1, 4, 2, 5, 3 };

            Console.WriteLine("\n\narray data");
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine($"array[{i}] = {array[i]}");

            Console.WriteLine($"array.Rank : {array.Rank}");
            Console.WriteLine($"array.Length : {array.Length}\n");
            Console.WriteLine($"array.GetValue(3) : {array.GetValue(3)} = array[3] : {array[3]}\n");

            int[] array2 = new int[array.Length];

            Array.Copy(array, array2, array.Length);
            Console.WriteLine($"Array.Copy (array -> array2)\n");

            Array.Sort(array);
            Console.WriteLine($"Array.Sort(array)\n");

            Console.WriteLine("array data");
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine($"array[{i}] = {array[i]}");

            Console.WriteLine("\narray2 data");
            for (int i = 0; i < array2.Length; i++)
                Console.WriteLine($"array2[{i}] = {array2[i]}");


 


        }
    }
}
