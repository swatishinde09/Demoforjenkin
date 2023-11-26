using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoforjenkin
{
    internal class Program
    {
        public void show()
        {
            Console.WriteLine("Hello World");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.show();
            Console.ReadLine();
        }
    }
}
