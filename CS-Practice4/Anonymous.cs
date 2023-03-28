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

    delegate int math(int a,int b);
    class delegateLambda
    {
        public delegateLambda()
        {
            var sum = (int num1,int num2) => {
                return (num1 + num2);
                };
            var sub = (int num1, int num2) => {
                return (num1 - num2);
            };

            sum += sub;
            Delegate[] arr = sum.GetInvocationList();
            foreach(Delegate a in arr)
            {
                Console.WriteLine(a.DynamicInvoke(3, 4));
            }


            //Console.WriteLine(sum(2, 3));
        }
    }

    class Lambda { 
        public Lambda()
        {
            List <int> nums = new List<int>() { 1,2,3,4,5,6,7,8,9,10};
            var square = (int x) => x * x;
            foreach(int x in nums)
            {
                Console.WriteLine(square(x));
            }
            Console.WriteLine("----------------------");
            List<int> DivisibleBy5 = nums.FindAll((n) => (n % 2 == 0));
            
            foreach(int n in DivisibleBy5)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("----------------------");
            Dictionary<string,int> myDict = new Dictionary<string,int>();
            myDict.Add("a", 1);
            myDict.Add("b", 6);
            myDict.Add("e", 3);
            myDict.Add("d", 4);
            foreach(var x in myDict.OrderBy(x=>x.Value).ToList())
            {
                Console.WriteLine(x.Key+x.Value);
            }

        }
    }

}
