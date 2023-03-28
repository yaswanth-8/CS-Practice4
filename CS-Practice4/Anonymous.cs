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
            mathOperations dAdd = delegate (int a, int b) { Console.WriteLine( a + b); };
            dAdd(2, 6);
        }
        
    }

    delegate int add(int a,int b);
    class lamda
    {
        public lamda()
        {
            //int num = 1, num2 = 2;
            add sum = (num1, num2) => { return num1 + num2; };
            Console.WriteLine(sum(2, 3));
        }
    }
}
