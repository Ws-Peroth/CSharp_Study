﻿using System;
using System.Collections.Generic;
using System.Text;

namespace 객체지향문법_4_1_클래스
{
    public class ClassInfo
    {
        private int data;   // 필드
        private string name;

        public ClassInfo(int data, string name) // 생성자
        {
            Console.WriteLine("[4.1.4] \n\n생성자 : [객체 생성시 호출]");
            this.data = data;   // 변수
            this.name = name;
        }

        public void Method(int param)   // 메소드
        {
            Console.WriteLine("[메소드 호출]");
            Console.WriteLine("Data : " + data + ", Name : " + name + ", Param : " + param + "\n\n");
        }
    }
}
