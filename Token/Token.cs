using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Token
{
    class Token
    {
        public static void Main(string[] args)
        {
            var cts = new CancellationTokenSource();
            var token = cts.Token;

            var t = Task.Factory.StartNew(() =>
            {
                try
                {
                    while(
                }
            })
        }
    }
}
