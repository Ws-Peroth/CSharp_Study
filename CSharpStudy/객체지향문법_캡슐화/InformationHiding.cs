using System;
using System.Collections.Generic;
using System.Text;

namespace 객체지향문법_4_2_캡슐화
{
    class InformationHiding
    {
        private int data = 0;

        public void SetData(int data)
        {
            Console.WriteLine("[After] data : " + data);
            this.data = data;
            Console.WriteLine("[Before] data : " + data + "\n");
        }
        public int GetData()
        {
            Console.WriteLine("Return Data : " + data);
            return data;
        }

        public void RunMethod()
        {
            Console.WriteLine("[private int data]");
            Console.WriteLine("은닉시킨 필드 data에 대해 GetData(), SetData() 만으로 접근하도록 함\n");

        }
    }
}
