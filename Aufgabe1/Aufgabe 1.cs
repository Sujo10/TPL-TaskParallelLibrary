using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe1
{
    class Program
    {
        static async Task SearchFilesAsync(string dirName, FileInfo[] files, string pattern) {
            Console.WriteLine("Files in " + dirName + " containing '" + pattern + "'");
            foreach (var file in files) {
                StreamReader r = new StreamReader(file.FullName);
                string s = await r.ReadToEndAsync();
                if (s.IndexOf(pattern) >= 0) {
                    Console.WriteLine(" " + file.Name);
                }
            }
        }
        public static void Main(string[] arg) {
            if (arg.Length == 2) {
                try {
                    //-- get the names of all files in the directory
                    var dir = new DirectoryInfo(arg[0]);
                    var files = dir.GetFiles("*.cs");
                    //-- start reading and searching the files;
                    //-- must be a separate method because Main() must not be async
                    var t = SearchFilesAsync(arg[0], files, arg[1]);
                    //-- wait for the task to complete;
                    //-- all started subtasks run in background threads that would be
                    //-- terminated if Main() reaches its end
                    t.Wait();
                } catch (ArgumentException) {
                    Console.WriteLine("-- invalid directory name");
                }
            }
            else
            {
                Console.WriteLine("-- Synopsis: AsyncSearch directoryName searchPattern");
            }
            Console.ReadKey();
        }
    }
}

