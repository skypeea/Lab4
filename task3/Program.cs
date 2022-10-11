using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число A");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число B");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число C");
            int c = Convert.ToInt32(Console.ReadLine());
            int a1 = a;//
            int b1 = b; //для вывода в конце выполнения программы
            int countHorizontal = 0;
            int countVertical = 0;
            while ((a-c) >=0)
            {
                countHorizontal++;
                a = a - c;
            }
            while ((b - c) >= 0)
            {
                countVertical++;
                b = b - c;
            }
            Console.WriteLine("В прямоугольнике со сторонами " + a1 + ", " + b1 + " поместится " + countHorizontal + countVertical + " квадратов со стороной " + c);
            Console.ReadKey();
        }
    }
}
