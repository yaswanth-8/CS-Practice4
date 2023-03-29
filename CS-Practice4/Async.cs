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
            // Firstmethod();
            /*
             Thirdmethod();
             Secondmethod();
             Fourthmethod();
             Console.ReadLine();*/

            /*
                        iteratingFunction();
                        printingFunction();
                        Console.ReadLine();*/

            //openFile();
            call();
            
            Console.ReadLine();

        }
        public static async void call()
        {
            Task t1 = Firstmethod();
            Task t2 = Secondmethod();
            await Task.WhenAll(t1, t2).ContinueWith(_ =>
            {
                Console.WriteLine("both tasks have completed");
            });
            Fourthmethod();
        }

         async void openFile()
        {
           await Task.Run( ( )  =>
           {


               Console.WriteLine("inside run");
               FileStream fs = new FileStream("D:\\C#\\file1.txt", FileMode.OpenOrCreate);
               Console.WriteLine("File1 is opened");
               writeFile(fs);
           
           });
           
           
        }

        public void writeFile(FileStream fs)
        {
            StreamWriter sw = new StreamWriter(fs);
            sw.Write("Yaswanth");
            Console.WriteLine("writen name");
            sw.Close();
            fs.Close();
        }









        static async void iteratingFunction()
        {
            await Task.Run(async () =>
            {
                for (int i = 0; i < 10; i++)
                {
                    await Task.Delay(200);
                    Console.WriteLine("from iterating function " + i);
                }

            });
            
        }

        static async void printingFunction()
        {
            for (int i = 0; i < 10; i++)
            {
               await Task.Delay(200);
                Console.WriteLine("Printing function");
            }
        }

        public static async Task Firstmethod()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("Running....");
            });

            Console.WriteLine("Method1");
        }

        public static async Task Secondmethod()
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
