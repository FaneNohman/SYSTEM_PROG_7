using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            ////последовательнно
            //Console.WriteLine("just await");
            //await Func("text 1");
            //await Func("text 2");
            //await Func("text 3");
            //Console.WriteLine();

            ////параллельнно WhenAll
            //Console.WriteLine("WhenAll");
            //var a = Func("text 1");
            //var b = Func("text 2");
            //var c = Func("text 3");
            //await Task.WhenAll(a, b, c);
            //Console.WriteLine();

            ////параллельнно WhenAny
            //Console.WriteLine("WhenAny");
            //a = Func("text 1");
            //b = Func("text 2");
            //c = Func("text 3");
            //await Task.WhenAny(a, b, c);
            //Console.ReadLine();

            ////try catch
            //var task1 = PrintError();
            //var task2 = PrintError();
            //var task3 = PrintError();
            //var waitAll = Task.WhenAll(task1, task2, task3);
            //try
            //{
            //    await waitAll;
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine($"Exception: {ex.Message}");
            //    Console.WriteLine($"IsFaulted: {waitAll.IsFaulted}");
            //    if (waitAll.Exception != null)
            //    {
            //        foreach (var exception in waitAll.Exception.InnerExceptions)
            //        {
            //            Console.WriteLine($"InnerException: {exception.Message}");
            //        }
            //    }

            //}

            //return value
            var task = ReturnValue();
            await task;
            Console.WriteLine(task.Result);

            Console.ReadLine();
        }
        public static async Task Func(string str)
        {
            await Task.Delay(1000);
            Console.WriteLine(str);
        }
        public static async Task PrintError()
        {
            await Task.Delay(1000);
            throw new ArgumentException($"Invalid method");
        }
        public static async Task<int> ReturnValue()
        {
            await Task.Delay(100);
            return 100;
        }
    }
}
