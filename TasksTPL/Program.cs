using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TasksTPL
{
    class Tasks
    {
        public static void mult()
        {
            int a = 1;
            int b = 2;
            int c = a * b;

            Console.WriteLine(c);
        }

        public static void subt()
        {
            int a = 10;
            int b = 2;
            int c = a - b;

            if (c < 0)
            {
                c = 0;
            }

            Console.WriteLine(c);
        }

        public static void addi()
        {
            int a = 1;
            int b = 2;
            int c = a + b;

            Console.WriteLine(c);
        }

        static void Main()
        {
            Task t1 = Task.Factory.StartNew(addi);
            Task t2 = Task.Factory.StartNew(mult);
            Task t3 = Task.Factory.StartNew(subt);

            Task[] tasks = {t1, t2, t3};

            

            Task.Factory.ContinueWhenAll(tasks, (setOfTasks) => { Console.WriteLine("Alle Tasks ausgeführt"); });

            Task.Factory.ContinueWhenAny(tasks, (firstTask) => { Console.WriteLine("Erster Task ausgeführt"); });

            Console.ReadLine();
        }
    }
}

