using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("vekove");
            var v = double.Parse(Console.ReadLine());
            var g = v * 100;
            var d = g * 365;
            var ch = d * 24;
            var m = ch * 60;
            Console.WriteLine(g);
            Console.WriteLine(d);
            Console.WriteLine(ch);
            Console.WriteLine(m);
           
        }
    }
}
