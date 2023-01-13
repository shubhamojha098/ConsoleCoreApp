using ConsoleCoreApp.Assingnment2;
using ConsoleCoreApp.OOPS;
using System.Diagnostics.CodeAnalysis;
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Read Key
/*Console.WriteLine("Press any key:");
//ConsoleKeyInfo ck= Console.ReadKey();
ConsoleKeyInfo ck= Console.ReadKey(true);
    Console.Write("*");
    Console.WriteLine($"\nPressed key is:{ck.Key}");
    Console.WriteLine($"Pressed key is:{ck.KeyChar}");*/
/*String password = "";
Console.WriteLine("Enter your Password");
ConsoleKeyInfo ck = Console.ReadKey(true);
while (ck.Key != ConsoleKey.Enter)

{
    Console.Write("*");
    password = password + ck.KeyChar;
    ck = Console.ReadKey(true);
}
Console.WriteLine($"\nPassword is:{password}");*/
/*
do
{
    ConsoleKeyInfo ck= Console.ReadKey(true);
    Console.Write("*");
    if (ck.Key != ConsoleKey.Enter)
        password += ck.KeyChar;
    else
        break;

}while(true);

Console.WriteLine($"\nPassword is:{password}");
*/

//using foreach
//It is forward only and read only
/*int[]arr=new int[5] {1,2,3,4,5};
Console.WriteLine("Array element are:");
foreach(int item in arr)
{
    //item=item+20;
    Console.WriteLine(item);
}*/

//int num = 30;
/*object obj = num;
Console.WriteLine(num);
int y=(int)obj;
Console.WriteLine(y);

float z=(float)obj;
Console.WriteLine(z);*/
/*int[]arr=new int[5] { 10, 20, 30, 40, 50 };
foreach (var item in arr)
{
    if (item == 20)
    {
        Console.WriteLine(item);
    }
}
/*
*************************************
//Ques3.Maskify("123456789");
//Console.WriteLine(Ques3.Maskify("12345678101"));
/*Console.WriteLine("Enter the account number");
String acc= Console.ReadLine();
Console.WriteLine(Ques3.Maskify(acc));
int[] arr = new int[] { 92, 6, 73, -77, 81, -90, 99, 8, -85, 34 };
Console.WriteLine($"The count is:{Ques3.Count(arr)}");
Console.WriteLine($"The sum is:{Ques3.Sum(arr)}");
 ***********************************************************
 */

/*
**************************************
12.01 / 2023
************************************** 
*/
//Object creation
//Employee emp = new Employee();

//Member Calling
/*emp.DisplayEmployeeDetails();//0 null 0
emp.setEmployeeDetails(1000,"Ratish",245000.0f);
emp.DisplayEmployeeDetails();//1000


Employee emp2 = emp;
emp2.DisplayEmployeeDetails();//1000
emp2.setEmployeeDetails(1001, "Rohit", 245000.0f);
emp.DisplayEmployeeDetails();//1001
emp2.DisplayEmployeeDetails();//1001

var emp3 = new Employee();
dynamic emp4 = new Employee();

Employee emp5 = new();
emp5.DisplayEmployeeDetails();*/
/*
 **************************
 Method calling
**************************** 

MethodCalling obj = new();
int num1 = 30, num2 = 50;
Console.WriteLine($"Num1:{num1}\tNum2:{num2}");
obj.CallByValue(num1, num2);
Console.WriteLine($"Num1:{num1}\tNum2:{num2}");

obj.CallByRef(ref num1, ref num2);
Console.WriteLine($"Num1:{num1}\tNum2:{num2}");
int num1 = 150, num2 = 10, sum, multi, div;
obj.CallByOutput(num1, num2, out sum, out multi, out div);//This is also call method returning  multiple values
Console.WriteLine($"Sum:{sum}\tMultiplication:{multi}\tDivide:{div}");

obj.CallByNamedOptional(101, "Rohit", "Kumar", 40000);
obj.CallByNamedOptional(id:101, fname:"Rohit", surname:"Kumar", salary:40000);
obj.CallByNamedOptional(id: 101, fname: "Rohit", surname: "Kumar");
obj.CallByNamedOptional(id: 101, fname: "Rohit");
obj.CallByNamedOptional(id: 101);
obj.CallByNamedOptional(id: 101, fname: "Rohit", salary: 40000);*/
/*
 *************************
 13.01.2023
************************** */
/*
Employee emp1 = new Employee();
Employee emp2 = new();
Employee emp3 = new(101, "Rohit", 25000);
Employee emp4 = new(102, "Shubham", 23000);
Employee emp5 = new(103, 30000);

emp1.DisplayEmployeeDetails();
emp2.DisplayEmployeeDetails();
emp3.DisplayEmployeeDetails();
emp4.DisplayEmployeeDetails();
emp5.DisplayEmployeeDetails();
GC.Collect(0);*/
//using point class
/*Point p1 = new Point(10, 20);
Point p2 = new Point(20, 30);
Point p3 = p1 + p2;
Console.WriteLine(p1);
Console.WriteLine(p2);
Console.WriteLine(p3);
Point p4 = p1 - p2;
Console.WriteLine(p4);
if (p1 == p2)
{
    Console.WriteLine("Both are same");
}
else
{
    Console.WriteLine("Both are Different");
}*/

//using static demo

/*StaticDemo s1 = new StaticDemo();
StaticDemo s2 = new StaticDemo();
StaticDemo s3 = new StaticDemo();
s3.DisplayId();

StaticDemo.DisplayCount();
s1.DisplayId();*/

SingletonPattern obj = SingletonPattern.GetObj();
obj.Display();