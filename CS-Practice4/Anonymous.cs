using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Practice4
{
    delegate void mathOperations(int x,int y);
    internal class Anonymous
    {
        public Anonymous() {
            mathOperations d1 = add;
            d1 += diff;
            d1 += mul;
            Delegate[] arr = d1.GetInvocationList();    
            foreach(mathOperations d in arr)
            {
                d(2, 3);
            }
            
        }
        public static void add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public static void diff(int x, int y)
        {
            Console.WriteLine(x - y);
        }
        public static void mul(int x, int y)
        {
            Console.WriteLine(x * y);
        }
    }
}
