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
            Action<string> print1 = (msg) => Console.Write(msg);
            print1("Hi Yaswanth");
        }
        /*public void print()
        {
            Console.WriteLine("Hello World");
        }*/
    }
}
