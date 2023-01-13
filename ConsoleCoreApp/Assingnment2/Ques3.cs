using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreApp.Assingnment2
{
    internal class Ques3
    {
        public static string Maskify(string password)
        {
            string m = "";
            if (password.Length == 4)
            {
                for (int i = 0; i < password.Length; i++)
                {
                    m += password[i];
                    //Console.Write(password[i]);
                }
            }
            else
            {
                for(int i = 0; i < password.Length - 4; i++)
                {
                    m = m + "#";
                    //Console.WriteLine("#");
                }
                for (int i = password.Length-4; i < password.Length; i++)
                {
                    m+= password[i];
                    //Console.Write(password[i]);
                }
            }
            return m;
            //Console.WriteLine($"\nPassword is:{password}");
        }

        /* public static void Main(int []arr)
           {
               int i,count=0,sum=0;
               for(i=0;i<arr.Length;i++)
               {
                   if (arr[i] > 0)
                   {
                       count++;
                   }
                   else
                   {
                       sum = sum + arr[i];
                   }
               }
               Console.WriteLine($"The count is:{count}");
               Console.WriteLine($"The sum is:{sum}");
           }*/
        public static int Count(int[] arr)
        {
            int i, count = 0;
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    count++;
                   
                }
            }
            return count;
        }
        public static int Sum(int[] arr)
        {
            int i, sum=0;
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    sum = sum + arr[i];

                }
            }
            return sum;
        }
        
        
    }
    
}
