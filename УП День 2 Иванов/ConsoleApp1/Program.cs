using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //if else №1
            Console.WriteLine("Введите число:");
            int number = int.Parse(Console.ReadLine());
            if (number > 0)
            {
                number += 5;
            }
            else if (number < 0)
            {
                number -= 5;
            }
            Console.WriteLine("Результат: " + number);
            Console.ReadKey();

            //if else №2
            Console.WriteLine("Введите число 1:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число 2:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число 3:");
            int c = int.Parse(Console.ReadLine());

            int max = a;
            if (b > max)
            {
                max = b;
            }
            if (c > max)
            {
                max = c;
            }
            Console.WriteLine(max);
            Console.ReadKey();

            //if else №3

            Console.WriteLine("Введите число 1:");
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число 2:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число 3:");
            int v = int.Parse(Console.ReadLine());

            int sum = 0;
            if (z > 0)
            {
                sum += z;
            }
            if (x > 0)
            {
                sum += x;            
            }
            if (v > 0)
            {
                sum += v;
            }
            Console.WriteLine(sum);
            Console.ReadKey();

            //if else №4
            Console.WriteLine("Введите число:");
            int q = int.Parse(Console.ReadLine());

            if (q > 10)
            {
                q *= 2;
            }
            Console.WriteLine(q);
            Console.ReadKey();

            //if else №5
            Console.WriteLine("Введите число от 1 до 7:");
            int day = int.Parse(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
                    
            }
            Console.ReadKey();

            // Циклы №1

            int number = 200;
            while (number % 17 != 0)
            {
                number++;
            }
            Console.WriteLine(number);

            // Циклы №2

            double distance = 10;
            int day = 1;

            while (distance < 20)
            {
                distance *= 1.05;
                day++;
            }

            Console.WriteLine("Человек пробежит 20 км на " + day + " день");

            distance = 10;
            day = 1;

            while (distance < 100)
            {
                distance *= 1.05;
                day++;
            }

            Console.WriteLine("Сумма пробега будет больше 100 км на " + day + " день");

            // Циклы №3

            Console.Write("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("Факториал числа {0} равен {1}", n, factorial);

            // Циклы №4

            Console.Write("Введите натуральное число: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            int i1 = 2;
            while (n1 % i1 != 0)
            {
                i1++;
            }

            Console.WriteLine("Наименьший делитель числа {0}, отличный от 1: {1}", n1, i1);

        }
    }
    }

