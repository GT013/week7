using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.print(5);
            p.print((5.26f).ToString());
            p.print(264.2871);
            p.print((int)1354.23);
            p.print("Hello World of C#");
            Console.ReadKey();

        }
        void print(int i)
        {
            Console.WriteLine("Printing int: {0}", i);
        }

        void print(double f)
        {
            Console.WriteLine("Printing float: {0}", f);
        }

        void print(string s)
        {
            Console.WriteLine("Printing string: {0}", s);
        }

    }

}


