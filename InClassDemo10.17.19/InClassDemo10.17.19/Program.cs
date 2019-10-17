using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassDemo10._17._19
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 mc1 = new Class1(123, "str1");
            Class1 mc2 = new Class1(123, "str1");
            Class1 mc3 = new Class1(456, "str1");

            //does mc1 == mc2
            if (mc1 == mc2) Console.WriteLine("mc1 == mc2");
            else Console.WriteLine("mc1 does not equal mc2");

            if (mc1.Equals(mc2)) Console.WriteLine("mc1 equals mc2");
            else Console.WriteLine("mc1 does not equal mc2");

            if (mc1.Equals(mc3)) Console.WriteLine("mc1 equals mc3");
            else Console.WriteLine("mc1 does not equal mc3");
        }
    }
}
