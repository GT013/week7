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
            Vector v1 = new Vector(1, 4);
            Vector v2 = new Vector(8, 5);
            Vector v3 = v1 + v2;
            Console.WriteLine("vector v1 = " + v1);
            Console.WriteLine("vector v2 = " + v2);
            Console.WriteLine("vector v3 = " + v3);
            Console.WriteLine("-v3 = " + (-v3));
            Console.ReadKey();


        }

    }
    class Vector
    {
        public Vector(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public int X { get; set; }  // X - accessor (property)
        public int Y { get; set; }  // Y - accessor (property)

        public override string ToString()
        {
            return string.Format("({0},{1})", X, Y);
        }
        // All operator overloads must be public and static.
        public static Vector operator +(Vector v1, Vector v2) //binary operator +
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y);
        }
        public static Vector operator -(Vector v1)  //unary operator -
        {
            return new Vector(-v1.X, -v1.Y);
        }
    }


}


