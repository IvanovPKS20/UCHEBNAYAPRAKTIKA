using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
//1
            string a = "hello ";
            string b = "world";
            string c = a + b;
            Console.WriteLine(c);
            Console.ReadKey();
//2
            int chislo1 = 5;
            int chislo2 = 5;

            Console.WriteLine("Сложение: " + (chislo1 + chislo2));
            Console.WriteLine("Вычитание: " + (chislo1 - chislo2));
            Console.WriteLine("Умножение: " + (chislo1 * chislo2));
            Console.WriteLine("Деление: " + (chislo1 / chislo2));
            Console.ReadKey();
//3
            Console.WriteLine("Введите имя:");
            string z = Console.ReadLine();
            Console.WriteLine("Введите фамилию:");
            string x = Console.ReadLine();
            Console.WriteLine("Введите отчество:");
            string v = Console.ReadLine();
            Console.WriteLine(z +" "+ x + " "+ v);
            Console.ReadKey();
//4
            int php = 100;
            int pdm = 20;
            int pdf = 10;

            int mhp = 50;
            int mdm = 20;
            int mdf = 5;

            int php1 = mdm / pdf;
            int php2 = php - php1;
            int mhp1 = pdm / mdf;
            int mhp2 = mhp - mhp1;
            Console.WriteLine("У игрока осталось здоровья: " + php2);
            Console.WriteLine("У монстра осталось здоровья: " + mhp2);
            Console.WriteLine("Урона нанёс игрок: " + mhp1);
            Console.WriteLine("Урона нанёс монстр: " + php1);
            Console.ReadKey();
        }
    }
}


