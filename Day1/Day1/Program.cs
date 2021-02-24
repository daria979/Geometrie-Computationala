using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Program
    {
        /// <summary>
        /// Se dau 2 puncte A si B (si C). Sa se afiseze: 
        /// ecuatia
        /// distanta
        /// coliniaritate 2 puncte
        /// concureta 3 drepte
        /// </summary>
        /// <param name="args"></param>
        /// 
        static int xA, yA, xB, yB, xC, yC;
        static string sep = "-------------------------------------------------";
        static void initializare2puncte()
        {
            Console.WriteLine("Coordonatele punctului A:");

            Console.Write("xA: ");
            xA = int.Parse(Console.ReadLine());
            Console.Write("yA: ");
            yA = int.Parse(Console.ReadLine());

            Console.WriteLine("Coordonatele punctului B:");

            Console.Write("xB: ");
            xB = int.Parse(Console.ReadLine());
            Console.Write("yB: ");
            yB = int.Parse(Console.ReadLine());


            Console.WriteLine();

            Console.WriteLine($"A({xA},{yA})");
            Console.WriteLine($"B({xB},{yB})");
            
            Console.WriteLine();
        }

        static void initializare3puncte()
        {
            Console.WriteLine("Coordonatele punctului A:");

            Console.Write("xA: ");
            xA = int.Parse(Console.ReadLine());
            Console.Write("yA: ");
            yA = int.Parse(Console.ReadLine());

            Console.WriteLine("Coordonatele punctului B:");

            Console.Write("xB: ");
            xB = int.Parse(Console.ReadLine());
            Console.Write("yB: ");
            yB = int.Parse(Console.ReadLine());


            Console.WriteLine("Coordonatele punctului C:");

            Console.Write("xC: ");
            xC = int.Parse(Console.ReadLine());
            Console.Write("yC: ");
            yC = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine($"A({xA},{yA})");
            Console.WriteLine($"B({xB},{yB})");
            Console.WriteLine($"B({xC},{yC})");

            Console.WriteLine();

        }
        static void ecuatia_dreptei()
        {
            Console.WriteLine("Ecuatia dreptei:");
          
            Console.WriteLine();

            int t1, t2, t3;
            t1 = yA - yB;
            t2 = -1 * (xA - xB);
            t3 = xA * yB - yA * xB;

            void ecuatie_constructor1(char semn1, char semn2)
            { 
                Console.WriteLine($"(AB): {t1}x{semn1}{t2}y{semn2}{t3} = 0");
            }

            if (t2 < 0 && t3 < 0)
                ecuatie_constructor1(' ', ' ');

            if (t2 < 0 && t3 > 0)
                ecuatie_constructor1(' ', '+');

            if (t2 > 0 && t3 < 0)
                ecuatie_constructor1('+', ' ');

            if (t2 > 0 && t3 > 0)
                ecuatie_constructor1('+', '+');


            // TODO: De tratat cazurile cand t1,t2,t3 dau 0!!!
            Console.WriteLine(sep);
        }

        static void distanta()
        {
            Console.WriteLine("Distanta dintre punctele A si B:");
           
            Console.WriteLine();

            double d;
            d = Math.Sqrt((xB - xA) * (xB - xA) + (yB - yA) * (yB - yA));
            d = Math.Round(d, 3);
            Console.WriteLine($"|AB|: {d}");
            Console.WriteLine(sep);
        }

        static void coliniaritate()
        {
            Console.WriteLine("Coliniaritatea a 3 puncte:");
            
            Console.WriteLine();


            int cond;
            cond = xA * yB + xB * yC + xC * yA - xC * yB - xA * yC - xB * yA;

            if (cond == 0)
                Console.WriteLine("Cele 3 puncte sunt coliniare!");
            else
                Console.WriteLine("Cele 3 puncte NU sunt coliniare!");
            Console.WriteLine(sep);
        }

        //de citit coeficientii a celor 3 drepte
        //de afisat cele 3 ecuatii
        //de verificat daca sunt concurente sau nu
        static void concurenta3()
        {
            Console.WriteLine("Concurenta a 3 drepte:");
            
            Console.WriteLine();

            double a1, a2, a3, b1, b2, b3, c1, c2, c3;
            Console.WriteLine("Introduceti coeficientii celor 3 drepte:");
            Console.WriteLine("Coeficientii dreptei (d1):");

            Console.Write("a1: ");
            a1 = double.Parse(Console.ReadLine());
            a1 = Math.Round(a1, 2);
            Console.Write("a2: ");
            a2 = double.Parse(Console.ReadLine());
            a2 = Math.Round(a2, 2);
            Console.Write("a3: ");
            a3 = double.Parse(Console.ReadLine());
            a3 = Math.Round(a3, 2);

            Console.WriteLine("Coeficientii dreptei (d2):");

            Console.Write("b1: ");
            b1 = double.Parse(Console.ReadLine());
            b1 = Math.Round(b1, 2);
            Console.Write("b2: ");
            b2 = double.Parse(Console.ReadLine());
            b2 = Math.Round(b2, 2);
            Console.Write("b3: ");
            b3 = double.Parse(Console.ReadLine());
            b3 = Math.Round(b3, 2);


            Console.WriteLine("Coeficientii dreptei (d3):");

            Console.Write("c1: ");
            c1 = double.Parse(Console.ReadLine());
            c1 = Math.Round(c1, 2);
            Console.Write("c2: ");
            c2 = double.Parse(Console.ReadLine());
            c2 = Math.Round(c2, 2);
            Console.Write("c3: ");
            c3 = double.Parse(Console.ReadLine());
            c3 = Math.Round(c3, 2);

            Console.WriteLine();

            double det;
            det = a1 * b2 * c3 + b1 * c2 * a3 + a2 * b3 * c1 - a3 * b2 * c1 - b3 * c2 * a1 - a2 * b1 * c3;

            void ecuatie_constructor2(int nrd, double a,double b, double c,char semn1, char semn2, char semn3)
            {
                Console.WriteLine($"(d{nrd}): {semn1}{a}x{semn2}{b}y{semn3}{c} = 0");
            }

  
            //Semnele pentru ecuatia d1
            if (a1 > 0 && a2 > 0 && a3 > 0)
                ecuatie_constructor2(1,a1, a2, a3, '+', '+', '+');
            if (a1 > 0 && a2 > 0 && a3 < 0)
                ecuatie_constructor2(1,a1, a2, a3, '+', '+', ' ');
            if (a1 > 0 && a2 < 0 && a3 > 0)
                ecuatie_constructor2(1,a1, a2, a3, '+', ' ', '+');
            if (a1 < 0 && a2 > 0 && a3 > 0)
                ecuatie_constructor2(1,a1, a2, a3, ' ', '+', '+');
            if (a1 < 0 && a2 < 0 && a3 > 0)
                ecuatie_constructor2(1,a1, a2, a3, ' ', ' ', '+');
            if (a1 < 0 && a2 > 0 && a3 < 0)
                ecuatie_constructor2(1,a1, a2, a3, ' ', '+', ' ');
            if (a1 > 0 && a2 < 0 && a3 < 0)
                ecuatie_constructor2(1,a1, a2, a3, '+', ' ', ' ');
            if (a1 < 0 && a2 < 0 && a3 < 0)
                ecuatie_constructor2(1,a1, a2, a3, ' ', ' ', ' ');

            //Semnele pentru ecuatia d2
            if (b1 > 0 && b2 > 0 && b3 > 0)
                ecuatie_constructor2(2,b1, b2, b3, '+', '+', '+');
            if (b1 > 0 && b2 > 0 && b3 < 0)
                ecuatie_constructor2(2,b1, b2, b3, '+', '+', ' ');
            if (b1 > 0 && b2 < 0 && b3 > 0)
                ecuatie_constructor2(2,b1, b2, b3, '+', ' ', '+');
            if (b1 < 0 && b2 > 0 && b3 > 0)
                ecuatie_constructor2(2,b1, b2, b3, ' ', '+', '+');
            if (b1 < 0 && b2 < 0 && b3 > 0)
                ecuatie_constructor2(2,b1, b2, b3, ' ', ' ', '+');
            if (b1 < 0 && b2 > 0 && b3 < 0)
                ecuatie_constructor2(2,b1, b2, b3, ' ', '+', ' ');
            if (b1 > 0 && b2 < 0 && b3 < 0)
                ecuatie_constructor2(2,b1, b2, b3, '+', ' ', ' ');
            if (b1 < 0 && b2 < 0 && b3 < 0)
                ecuatie_constructor2(2,b1, b2, b3, ' ', ' ', ' ');

            //Semnele pentru ecuatia d3
            if (c1 > 0 && c2 > 0 && c3 > 0)
                ecuatie_constructor2(3, c1, c2, c3, '+', '+', '+');
            if (c1 > 0 && c2 > 0 && c3 < 0)
                ecuatie_constructor2(3, c1, c2, c3, '+', '+', ' ');
            if (c1 > 0 && c2 < 0 && c3 > 0)
                ecuatie_constructor2(3, c1, c2, c3, '+', ' ', '+');
            if (c1 < 0 && c2 > 0 && c3 > 0)
                ecuatie_constructor2(3, c1, c2, c3, ' ', '+', '+');
            if (c1 < 0 && c2 < 0 && c3 > 0)
                ecuatie_constructor2(3, c1, c2, c3, ' ', ' ', '+');
            if (c1 < 0 && c2 > 0 && c3 < 0)
                ecuatie_constructor2(3, c1, c2, c3, ' ', '+', ' ');
            if (c1 > 0 && c2 < 0 && c3 < 0)
                ecuatie_constructor2(3, c1, c2, c3, '+', ' ', ' ');
            if (c1 < 0 && c2 < 0 && c3 < 0)
                ecuatie_constructor2(3, c1, c2, c3, ' ', ' ', ' ');

            Console.WriteLine();
            if (det == 0)
                Console.WriteLine("Dreptele sunt concurente");
            else
                Console.WriteLine("Dreptele NU sunt concurente");
            Console.WriteLine(sep);
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Lista de probleme:");

            List<string> probleme= new List<string>();

            probleme.Add("Ecuatia unei dreptei");
            probleme.Add("Distanta dintre 2 puncte");
            probleme.Add("Coliniaritatea a 3 puncte");
            probleme.Add("Concurenta a 3 drepte");
            probleme.Add("Toate");

            int nr = 1;
            foreach (var problema in probleme )
            {
                Console.WriteLine(nr +". "+problema);
                nr++;
            }

            Console.Write("Apasati tasta corespunzatoare numarului problemei pentru rulare:");
            int key = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();

            switch (key)
            {
                case 1:
                    initializare2puncte();
                    ecuatia_dreptei();
                    break;
                case 2:
                    initializare2puncte();
                    distanta();
                    break;
                case 3:
                    initializare3puncte();
                    coliniaritate();
                    break;
                case 4:
                    concurenta3();
                    break;
                case 5:
                    initializare3puncte();
                    ecuatia_dreptei();
                    Console.WriteLine();
                    distanta();
                    Console.WriteLine();
                    coliniaritate();
                    Console.WriteLine();
                    concurenta3();
                    break;
                default:
                    Console.WriteLine("Numarul problemei nu a fost introdus corect.");
                    break;
            }
            Console.WriteLine();
            Console.ReadKey();
           
            
        }
    }
}
