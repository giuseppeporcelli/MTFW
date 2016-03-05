using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTFW.Host
{
    class Host
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Framework starting...");
            Framework.Start();
            Console.WriteLine("Framework running...");
            Console.ReadLine();
        }
    }
}
