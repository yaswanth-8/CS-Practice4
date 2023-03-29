using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Practice4
{
    internal class AsyncClass
    {
        public AsyncClass()
        {
            Firstmethod();
            Secondmethod();
            Console.ReadLine();
        }

        public static async void Firstmethod()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("Running....");
            });

            Console.WriteLine("Method1");
        }

        public static async void Secondmethod()
        {
            Console.WriteLine("Method2");
        }
    }
}
