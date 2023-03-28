using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Practice4
{
     delegate void DoSum(int x, int y);
    class delegates
    {
        public delegates (){

            DoSum add = Sum;
            performSum(add, 2, 6);

        }

        public static void Sum(int x, int y)
        {
            Console.WriteLine("Sum is "+( x + y));
        }

        public static void performSum(DoSum doSum,int x,int y)
        {
            doSum(x,y);
        }
    }
   
}
