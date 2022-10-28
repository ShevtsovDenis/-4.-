using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Часть_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k_p, k_o;
            k_p = k_o = 0;
            Console.WriteLine("Введите последовательность целых чисел.");
            n = Convert.ToInt32(Console.ReadLine());
            do
            {
                if (n < 0)
                {
                    k_o++;
                }
                else
                {
                    k_p++;
                }
                n = Convert.ToInt32(Console.ReadLine());
            }
            while (n != 0);
            if (k_p == k_o)
            {
                Console.WriteLine("Количество положительных и отрицательных чисел одинаково.");
            }
            if (k_p > k_o)
            {
                Console.WriteLine("Количество положительных чисел превышает количество отицательных.");
            }
            else if (k_p<k_o)
            {
                Console.WriteLine("Количество отицательных чисел превышает количество положительных.");
            }
            Console.WriteLine("Для завершения нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
