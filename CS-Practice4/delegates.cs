using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Practice4
{
    delegate void DoSum(int x, int y);
    internal class delegates
    {
        public delegates (){

            DoSum add = Sum;
            add(2,6);
        }

        public static void Sum(int x, int y)
        {
            Console.WriteLine("Sum is "+( x + y));
        }
    }
   
}
