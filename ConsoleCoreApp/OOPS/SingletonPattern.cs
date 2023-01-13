using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreApp.OOPS
{
    internal class SingletonPattern
    {
        private SingletonPattern() { }
        static SingletonPattern singleton;
         public static SingletonPattern GetObj() { 
            return singleton==null?new SingletonPattern():singleton; 
        }
         
        public  void Display()
        {
            Console.WriteLine("Display from singleton pattern");
        }
       
       
    }
}
