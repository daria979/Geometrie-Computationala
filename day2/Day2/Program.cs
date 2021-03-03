using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    class Program
    {
        private static void constructor_vector(int a, int b, int c)
        {
            if (a == 0)
                Console.Write("");
            else
                Console.Write($"{a}i");
            if (b < 0)
                Console.Write($"{b}j");
            else if (b == 0)
                Console.Write("");
            else
                Console.Write($"+{b}j");

            if (c < 0)
                Console.Write($"{c}z");
            else if (c == 0)
                Console.Write("");
            else
                Console.Write($"+{c}z");
        }

        static void Main(string[] args)
        {

            int x1, y1, z1, x2, y2, z2, x3, y3, z3;

            Console.WriteLine("Vector 1");
            Console.Write("x1=");
            x1 = int.Parse(Console.ReadLine());
            Console.Write("y1=");
            y1 = int.Parse(Console.ReadLine());
            Console.Write("z1=");
            z1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Vector 2");
            Console.Write("x2=");
            x2 = int.Parse(Console.ReadLine());
            Console.Write("y2=");
            y2 = int.Parse(Console.ReadLine());
            Console.Write("z2=");
            z2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Vector 3");
            Console.Write("x3=");
            x3 = int.Parse(Console.ReadLine());
            Console.Write("y3=");
            y3 = int.Parse(Console.ReadLine());
            Console.Write("z3=");
            z3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Primul vector:");
            Console.Write("v1=");
            constructor_vector(x1, y1, z1);
            Console.WriteLine();
            Console.WriteLine("Al doilea  vector:");
            Console.Write("v2=");
            constructor_vector(x2, y2, z2);
            Console.WriteLine();
            Console.WriteLine("Al treilea  vector:");
            Console.Write("v3=");
            constructor_vector(x3, y3, z3);
            Console.WriteLine();
            
            double det_i = y1 * z2 - y2 * z1;
            double det_j = x2 * z1 - z2 * x1;
            double det_k = x1 * y2 - x2 * y1;
            double det = det_i + det_j + det_k;
            if (det == 0)
            {
                Console.Write("V1 X V2 = 0");
            }
            else
                Console.Write("V1 X V2=");
            constructor_vector(y1 * z2 - y2 * z1, x2 * z1 - z2 * x1, x1 * y2 - x2 * y1);
            Console.WriteLine();
            if (det == 0)
                Console.WriteLine("vectorii sunt coliniari");
            else
                Console.WriteLine("vectorii nu sunt coliniari");
            Console.WriteLine();
            Console.WriteLine("|v1 x v2|=");
            double marime = Math.Sqrt(det_i * det_i + det_j * det_j + det_k * det_k);
            Console.Write(marime);
            

            double produs_mixt = x1 * y2 * z3 + x2 * y3 * z1 + x3 * y1 * z2 - z1 * y2 * x3 - z2 * y3 * x1 - z3 * y1 * x2;

            Console.WriteLine($"Produsul mixt este = {produs_mixt}");

            if (produs_mixt == 0)
                Console.WriteLine("Vectorii sunt coplanari");
            else
                Console.WriteLine("Vectorii nu sunt coplanari");

            double volum = Math.Abs(produs_mixt);

            Console.WriteLine($"Volumul este {volum}");



        }
    }
}
