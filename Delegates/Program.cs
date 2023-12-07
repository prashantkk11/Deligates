namespace Delegates
{
    //step1 : create a delegate class that matches the signature of the func to call
    public delegate void Del1();
    public delegate int DelAdd(int a, int b);
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

        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Substract(int a, int b)
        {
            return a - b;
        }

        static int Multi(int a, int b)
        {
            return a * b;
        }

        static int Divide(int a, int b)
        {
            return a / b;
        }

        static void Main1()
        {
            //step 2 : create an object of the delegate class and pass it the function name as a parameter
            Del1 objDel = new Del1(Display);
            //objDel is the delegate reference

            //step 3: call the function via the delegate reference
            objDel();
            //Display();
        }
        static void Main2()
        {
            Del1 objDel = Display;
            objDel();

            objDel = Show;
            objDel();
        }

        static void Main3()
        {
            Del1 objDel = Display;
            objDel();

            Console.WriteLine();
            objDel += Show;
            objDel();

            Console.WriteLine();
            objDel += Display;
            objDel();

            Console.WriteLine();
            objDel -= Display;
            objDel();
        }
        static void Main4()
        {
            DelAdd objDelAdd = Add;
            Console.WriteLine(objDelAdd(10,5));

            objDelAdd += Substract;
            Console.WriteLine(objDelAdd(10,5));

        }
        static void Main()
        {
            Del1 objDel = (Del1) Delegate.Combine(new Del1(Display), new Del1(Show), new Del1(Display));
            objDel();
            Console.WriteLine();
            //objDel = (Del1) Delegate.Remove(objDel, new Del1(Display));
            objDel = (Del1)Delegate.RemoveAll(objDel, new Del1(Display));
            objDel();

        }
        static int CallFunctionPassedByParam(DelAdd objDelAdd, int a, int b)
        {
            return objDelAdd(a, b);
        }
        static void Main6()
        {
            Console.WriteLine(CallFunctionPassedByParam(Add,10,5));
            Console.WriteLine(CallFunctionPassedByParam(Substract,10,5));
            Console.WriteLine(CallFunctionPassedByParam(Multi,2,4));
            Console.WriteLine(CallFunctionPassedByParam(Divide,10,5));
        }

    }
}