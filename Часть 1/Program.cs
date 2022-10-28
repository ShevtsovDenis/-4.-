using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Часть_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число, больше 0.");
            int n = Convert.ToInt32(Console.ReadLine());
            int x = 0;
            if (n <= 0)
            {
                Console.WriteLine("Введено неверное значение.");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    x += 2 * i - 1;
                }
                Console.WriteLine("Искомое число = {0}.", x);
            }
            Console.WriteLine("Для завершения нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
