using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Часть_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите три положительных числа A, B, C. Где А и В это стороны прямоугольника.");
            Console.WriteLine("Значение С это сторона квадрата, вписанного в прямоугольник.");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int n = 0;
            int l_a, l_b;
            l_a = l_b = c;
            if (c <=a && c <=b && a > 0 && b > 0 && c > 0)
            {
                while (l_a<=a)
                {
                    while (l_b<=b)
                    {
                        n++;
                        l_b += c;
                    }
                    l_b= c;
                    l_a+= c;
                }

                Console.WriteLine("Число квадратов, которые могут быть вписаны в заданный прямоугольник без наложений = {0}.", n);
            }
            else
                Console.WriteLine("Ведены неверные значения.");
            Console.WriteLine("Для завершения нажмите любую клавишу.");
            Console.ReadLine();
        }
    }
}
