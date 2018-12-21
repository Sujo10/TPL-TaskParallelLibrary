using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probierobjekt
{
    class Probierklasse
    {
        static void Main(string[] args)
        {
            for (var i = 0; i < 10; i++)
            {
                Task.Factory.StartNew((arg) =>
                {
                    int taskId = (int)arg;
                    Console.WriteLine(taskId);
                }, i);
            }

            Console.ReadLine();
        }
    }
}
