using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreApp.OOPS
{
    internal class MethodCalling
    {
        //Method for call by value 
        public void CallByValue(int x,int y)//30 50
        {
            x = x + 20;//50
            y = y + 30;//80
            Console.WriteLine($"X:{x}\tY:{y}");//50 80
        }
        //Method for call by refrence behaviour
        public void CallByRef(ref int x, ref int y)
        {
            x = x + 20;
            y = y + 30;
            Console.WriteLine($"X:{x}\tY:{y}");//50 80
        }

        //Method for call by refrence behaviour using out keyword
        public void CallByOutput(int x, int y,out int s,out int m,out int d)
        {
            s = x + y;
            m = x * y;
            d = x / y;
        }

        //Method for call by named/optional argument
        public void CallByNamedOptional(int id,string fname="Guest",string surname="",float salary=25000)
        {
            Console.WriteLine($"Welcome:{fname}{surname}");
            Console.WriteLine($"Id{id}\tSalary{salary}");

        }

    }
}
