﻿using System;
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
           // Firstmethod();
           
            Thirdmethod();
            Secondmethod();
            Fourthmethod();
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
            string msg = await Thirdmethod();
            Console.WriteLine("Method2 "+msg);
        }

        public static async Task<string> Thirdmethod()
        {
            await Task.Delay(5000);
            Console.WriteLine("inthird method");
            return "THirdMethod";
        }
        public static void Fourthmethod()
        {
            Console.WriteLine("In method4");
        }
    }
}