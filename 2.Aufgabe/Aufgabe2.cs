using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2.Aufgabe
{
    public class ParallelSearch
    {
        public static void Main(string[] args)
        {
            

            if (args.Length == 2)
            {
                try
                {
                    var dirName = args[0];
                    var pattern = args[1];
                    Console.WriteLine(args.Length);

                    var dir = new DirectoryInfo(dirName);
                    var files = dir.GetFiles("*.cs");

                    Console.WriteLine("Files in " + dir.FullName + " containing '" + pattern + "'");
                }
                catch(ArgumentException)
                {
                    Console.WriteLine("Du Invalid!");
                }
            }
            else
            {
                Console.WriteLine("Thynopthith");
            }
            Console.ReadKey();
        }
    }
}