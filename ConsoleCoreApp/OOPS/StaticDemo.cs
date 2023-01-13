using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreApp.OOPS
{
    internal class StaticDemo
    {
        int id;
        static int count;

        public StaticDemo()
        {
            this.id = count++;
        }
        public void DisplayId()
        {
            Console.WriteLine($"Id:{id}");
        }
        public static void DisplayCount( ) {
            Console.WriteLine($"Count:{count}");
        }
        static StaticDemo()
        {
            count= 0;
        }
    }
}
