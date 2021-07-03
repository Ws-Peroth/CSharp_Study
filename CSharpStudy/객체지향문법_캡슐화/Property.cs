using System;
using System.Collections.Generic;
using System.Text;

namespace 객체지향문법_4_2_캡슐화
{
    class Property
    {
        private int data = 0;
        public int Data
        {
            get 
            {
                Console.WriteLine("Return Data : " + data);
                return data; 
            }

            set 
            {
                Console.WriteLine("[After] data : " + data);
                data = value;
                Console.WriteLine("[Before] data : " + data + "\n");
            }
        }

        public void RunMethod()
        {
            Console.WriteLine("[private int data]");
            Console.WriteLine("은닉시킨 필드 data에 대해 Data의 get; set; 프로퍼티로 접근\n");

        }
    }
}
