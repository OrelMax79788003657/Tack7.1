using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tack7._1
{
    internal class Program
    {
        static void Main()
        {
            int triangles = 2;

            double t1x;
            double t1y;
            double t1z;

            double t2x;
            double t2y;
            double t2z;

            double S = 0;
            double S1 = 0;
            double S2 = 0;

            Console.WriteLine("Введите длины (x,y,z) сторон треугольника 1");
            t1x = Convert.ToDouble(Console.ReadLine());
            t1y = Convert.ToDouble(Console.ReadLine());
            t1z = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите длины (x,y,z) сторон треугольника 2");
            t2x = Convert.ToDouble(Console.ReadLine());
            t2y = Convert.ToDouble(Console.ReadLine());
            t2z = Convert.ToDouble(Console.ReadLine());



            Square(t1x, t1y, t1z, out S);
            S1 = S;
            Console.Write("Площадь 1го треугольника = ");
            Console.WriteLine(S1);


            Square(t2x, t2y, t2z, out S);
            S2 = S;
            Console.Write("Площадь 2го треугольника = ");
            Console.WriteLine(S2);

            if (S1 > S2)
            {
                Console.WriteLine("Площадь 1го треугольника больше!");
            }
            else if (S2 > S1)
            {
                Console.WriteLine("Площадь 2го треугольника больше!");
            }
            else
            {
                Console.WriteLine("Площади треугольников РАВНЫ!");
            }


            Console.ReadKey();
        }

        public static void Square(double x, double y, double z, out double S)
        {
            int a = 2;
            double p = (x + y + z) / 2d;
            S = Math.Sqrt(p * (p - x) * (p - y) * (p - z));
        }


    }
    
}
