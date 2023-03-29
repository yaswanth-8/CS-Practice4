using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Practice4
{
   
    internal class MyClass
    {
        public MyClass()
        {
            Action<int> print1 = (msg) => Console.Write(msg); //use when return type is void
            //print1("Hi Yaswanth");
            Console.WriteLine("--------------------");
            Func<int, int, int> print2 = (a, b) =>(a + b); //use when there is a return type
           int sum = print2(1, 2);
            print1(sum);
            Console.WriteLine("--------------------");
            Predicate<int> pd = (a) => a > 3;
            Console.WriteLine(pd(5));
        }
        
    }
}
