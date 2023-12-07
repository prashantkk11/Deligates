using System.Reflection.Metadata.Ecma335;

namespace ActionFuncPre
{
    internal class Program
    {
        static void Display()
        {
            Console.WriteLine("Display Called");
        }
        static void Show()
        {
            Console.WriteLine("Show Called");
        }
        static void Display(string a)
        {
            Console.WriteLine("Show Called " + a);
        }
        static void Display(string a,int b)
        {
            Console.WriteLine("Show Called " + a +" "+ b);
        }

            static string GetCurrentTime()
            {
                return System.DateTime.Now.ToLongTimeString();
            }
            static int GetDouble(int a)
            {
                return a * 2;
            }
            static int Add(int a, int b)
            {
                return a + b;
            }
            static bool IsEven(int a)
            {
                if (a % 2 == 0)
                    return true;
                else
                    return false;
            }
        static void Main1()
        {
            Action o1 = Display;
            o1();

            Action<string> o2 = Display;
            o2("Prashant");

            //Action<string,int> o3 = Display;
            //o3("Prashant", 11);

            Func<int, bool> o3 = IsEven;
            Console.WriteLine(o3(10));

            Func<int, int, int> o4 = Add;
            Console.WriteLine(o4(10, 5));

            Predicate<int> o5 = IsEven;
            Console.WriteLine(o5(10));
        }
    }
}

namespace AnonymousAndLambdas
{
    class Program1
    {
        static void Main()
        {
            Func<int, int, int> o1 = (a,b) => a + b;
            Console.WriteLine(o1(5,3));

            Func<string> o2 =()=> System.DateTime.Now.ToLongTimeString();
            Console.WriteLine(o2());

            Func<int,bool> o3 = a => a%2 == 0;
            Console.WriteLine(o3(4));

            //write a lambda for a function that takes an Employee object as a parameter
            //and returns true if the Basic is greater than 20000 else returns false

           // Employee obj = new Employee();
            Func<Employee, bool> o4 = (obj) => obj.Basic > 20000;
            Console.WriteLine(o4(new Employee { Basic = 25000}));
            Console.WriteLine(o4(new Employee { Basic = 15000 }));
        }
        public class Employee
        {
            public int EmpNo { get; set; }
            public string? Name { get; set; }
            public decimal Basic { get; set; }

        }
    }
}