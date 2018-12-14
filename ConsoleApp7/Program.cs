using System;
//using static System.Console;

namespace ConsoleApp7
{
/*
    class D
    {
        int Mem1;
        public static int Mem2;
    }

    class Program
    {
        static void Main()
        {
            D.Mem2 = 5;
            Console.WriteLine("Mem2 = {0}", D.Mem2);
        }
    }
}
*/

    class D
    {
        int Mem1;
        static int Mem2;

        public void SetVars(int v1, int v2)
        {
            Mem1 = v1; Mem2 = v2;
        }

        public void Display(string str)
        {
            Console.WriteLine("{0}:Mem1 ={1} Mem2={2}", str, Mem1, Mem2);
        }
    }

    class Program
    {
        static void Main()
        {
            D d1 = new D();
            D d2 = new D();

            d1.SetVars(2, 4);
            d1.Display("d1");

            d2.SetVars(15, 17);
            d2.Display("d2");

            d1.Display("d1");
        }
    }
}

/*
//using System;
using static System.Console;

namespace ConsoleApp7
{


    class D
    {
        public int Mem1;
        public static int Mem2;
    }

    class Program
    {
        static void Main()
        {
            D d1 = new D();
            D d2 = new D();

            //          Console.WriteLine("d1.Mem1 ={0}, d1.Mem2 ={1}", d1.Mem1, D.Mem2);
            //          Console.WriteLine("d2.Mem1 ={0}, d2.Mem2 ={1}", d2.Mem1, D.Mem2);
            //          Console.WriteLine();
            WriteLine("d1.Mem1 ={0}, d1.Mem2 ={1}", d1.Mem1, D.Mem2);
            WriteLine("d2.Mem1 ={0}, d2.Mem2 ={1}", d2.Mem1, D.Mem2);
            WriteLine();

            d1.Mem1 = 10;
            D.Mem2 = 30;

            WriteLine("d1.Mem1 ={0}, d1.Mem2 ={1}", d1.Mem1, D.Mem2);
            WriteLine("d2.Mem1 ={0}, d2.Mem2 ={1}", d2.Mem1, D.Mem2);
            WriteLine();

            d2.Mem1 = 28;
            D.Mem2 = 40;

            WriteLine("d1.Mem1 ={0}, d1.Mem2 ={1}", d1.Mem1, D.Mem2);
            WriteLine("d2.Mem1 ={0}, d2.Mem2 ={1}", d2.Mem1, D.Mem2);
            WriteLine();
        }
    }
}
*/