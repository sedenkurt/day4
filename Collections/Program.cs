using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"seden","sude","elif duru","aslı","irfan" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //Console.WriteLine(isimler[4]);

            List<string> isimler2 = new List<string> {"seden","sude","elif duru","asli","irfan" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[4]);

            isimler2.Add("bebek");
            Console.WriteLine(isimler2[5]);
            Console.WriteLine(isimler2[0]);


        }
    }
}
