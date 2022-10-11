using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            int countNegative = 0;
            int countPositive = 0;
            do
            {
                Console.WriteLine("Введите число +/-");
                input = Convert.ToInt32(Console.ReadLine());
                if (input < 0 && input != 0)
                {
                    countNegative++;
                }
                if (input > 0 && input != 0)
                {
                    countPositive++;
                }
            }
            while (input != 0);
            if (countNegative == countPositive)
            {
                Console.WriteLine("Количество отрицательных числе равно количеству положительных чисел");
                Console.ReadKey();
                return;
            }
            if (countNegative > countPositive)
            {
                Console.WriteLine("Отрицательных числе больше");
            }
            else
            {
                Console.WriteLine("Положительных чисел больше");
            }
            Console.ReadKey();
        }
    }
}
