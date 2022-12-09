using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._1MertSharp
{



    public class Baseclass
    {
        public int a;
        private int b;
        protected int c;

        public void fun()
        {
            Console.Write("Base class" + " " + c);
        }
    }
    public class Derived1 : Baseclass
    {
        public void fun2()
        {
            Console.WriteLine(base.c);
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Derived1 d = new Derived1();
            d.fun();
            Console.WriteLine(d.c);

            
        }
    }
}

    

