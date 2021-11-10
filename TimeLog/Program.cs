using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace TimeLog
{
    class Program
    {
        static void Main(string[] args)
        {
            var logFile = "logFile.txt";
            //File.Create(logFile);

            Console.WriteLine("Dealing with time!");

            Stack<string> time = new Stack<string>();

            //Logging 5 times and pushing to a stack
            for (int i =0; i < 5; i++)
            {
                time.Push(DateTime.Now.ToString("hh:mm:ss"));
                Console.WriteLine(time.Peek());
                Thread.Sleep(10000);
            }

            Console.WriteLine("////////////////");

            //Showing from a stack LIFO and appending to a file
            foreach (var second in time)
            {
                Console.WriteLine(second);
                File.AppendAllLines(logFile, new String[] { second.ToString() });
            }
        }
    }
}