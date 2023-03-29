using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Practice4
{
   // delegate void Print();
    internal class MyClass
    {
        public MyClass()
        {
            Action<int> print1 = (msg) => Console.Write(msg);
            //print1("Hi Yaswanth");
            Console.WriteLine("--------------------");
            Func<int, int, int> print2 = (a, b) => a + b;
            int sum = print2(1, 2);
            print1(sum);
        }
        /*public void print()
        {
            Console.WriteLine("Hello World");
        }*/
    }
}
