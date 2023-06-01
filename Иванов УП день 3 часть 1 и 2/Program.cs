using System;
using System.Collections.Generic;

namespace up3
{
    internal class Program
    {
        static void Main(string[] args)
        //День 3 часть 1
        {
            Employee employee = new Employee("fio", 10000, 1);
            List<Employee> employees = new List<Employee>()
            {
                new Employee ("Иванов Игорь Витальевич", 90000, 2),
                new Employee ("Смирнов Артур Арсентьевич", 55555, 2),
                new Employee ("Попов Даниил Ярославович", 25000, 3),
                new Employee ("Морозов Артемий Платонович", 25000, 3),
                new Employee ("Антонов Илья Константинович", 31000, 4),
                new Employee ("Коротков Максим Константинович", 25000, 4),
                new Employee ("Воробьев Николай Михайлович", 68000, 5),
                new Employee ("Чернышева Ангелина Ярославовна", 32000, 5),
                new Employee ("Козлова Анна Ильина", 45000, 1),
                new Employee ("Золотарева Мирослава Никитина", 32000, 1)

            };

            void A()
            {
                Console.WriteLine("A: ");
                foreach (var emp in employees)
                {

                    Console.WriteLine($"Id: {employee.Id()} Ф.И.О: {emp.Fio}, З/П: {emp.Salary}, Отдел: {emp.Department}");
                }
            }

            void B()
            {
                double summa = 0;
                foreach (var emp in employees)
                {
                    summa += emp.Salary;
                }
                Console.WriteLine("B: Сумма затрат на зарплату в месяц: " + summa);
            }

            void C()
            {
                double min = 999999999999;
                foreach (var emp in employees)
                {
                    if (emp.Salary < min)
                    {
                        min = emp.Salary;
                    }
                }
                Console.WriteLine("C: Минимальная зарплата " + min);
            }

            void D()
            {
                double max = 0;
                foreach (var emp in employees)
                {
                    if (emp.Salary > max)
                    {
                        max = emp.Salary;
                    }
                }
                Console.WriteLine("D: Максимальная зарплата " + max);
            }

            void E()
            {
                int count = 0;
                double summa = 0;
                foreach (var emp in employees)
                {
                    count++;
                    summa += emp.Salary;
                }

                Console.WriteLine("E: Среднее значение зарплаты: " + summa / count);
            }

            void F()
            {
                Console.WriteLine("F: ");
                foreach (var emp in employees)
                {
                    Console.WriteLine("Ф.И.О: " + emp.Fio);
                }
                Console.ReadKey();
            }
            
            A();
            Console.WriteLine();
            B();
            Console.WriteLine();
            C();
            Console.WriteLine();
            D();
            Console.WriteLine();
            E();
            Console.WriteLine();
            F();



            //День 3 часть 2.............................................................


            int Z = 1;
            while (Z == 1)
            {
                Console.WriteLine();
                Console.WriteLine("Веберите номер задания (1, 2, 3, 4, 5, 6, 7, 8)");
                int Zadanie = int.Parse(Console.ReadLine());
                if (Zadanie == 1) Zadanie_1(1.1);
                if (Zadanie == 2) Zadanie_2_a();
                if (Zadanie == 3) Zadanie_2_b();
                if (Zadanie == 4) Zadanie_2_c();
                if (Zadanie == 5) Zadanie_2_d(1.1);
                if (Zadanie == 6) Zadanie_2_e();
                if (Zadanie == 7) Zadanie_3_a();
                if (Zadanie == 8) Zadanie_3_b();
            }

            void Zadanie_1(double argument)
            {
                foreach (var emp in employees)
                {
                    Console.WriteLine("Зарплата " + emp.Fio + " увеличена до " + emp.Salary * argument);
                }
            }
            void Zadanie_2_a()
            {
                Console.WriteLine("Выберите отдел для определения минимальной зарплаты: ");
                double arg = Double.Parse(Console.ReadLine());
                double min = 9999999999999999;
                foreach (var emp in employees)
                {
                    if (emp.Salary < min)
                    {
                        if (emp.Department == arg)
                        {
                            min = emp.Salary;
                        }

                    }

                }
                Console.WriteLine("Минимальная зарплата = " + min);
            }
            void Zadanie_2_b()
            {
                Console.WriteLine("Выберите отдел для определения максимальной зарплаты: ");
                double arg = Double.Parse(Console.ReadLine());
                double max = 0;
                foreach (var emp in employees)
                {

                    if (emp.Salary > max)
                    {
                        if (emp.Department == arg)
                        {
                            max = emp.Salary;
                        }

                    }

                }
                Console.WriteLine("Максимальная зарплата = " + max);
            }
            void Zadanie_2_c()
            {
                Console.WriteLine("Выберите отдел для определения средней зарплаты: ");
                int count = 0;
                double summa = 0;
                double arg = Double.Parse(Console.ReadLine());
                foreach (var emp in employees)
                {
                    if (emp.Department == arg)
                    {
                        count++;
                        summa += emp.Salary;
                    }
                }

                Console.WriteLine("Средняя зарплаты по отделу = " + summa / count);
            }
            void Zadanie_2_d(double argument)
            {
                Console.WriteLine("Выберите отдел для увеличения зарплаты: ");
                double arg = Double.Parse(Console.ReadLine());
                foreach (var emp in employees)
                {
                    if (emp.Department == arg)
                    {
                        Console.WriteLine("Зарплата " + emp.Fio + " увеличена до " + emp.Salary * argument);
                    }

                }
            }
            void Zadanie_2_e()
            {
                Console.WriteLine("Введите отдел, сотрудников которого вы хотите увидеть: ");
                double arg = Double.Parse(Console.ReadLine());
                foreach (var emp in employees)
                {
                    if (emp.Department == arg)
                    {
                        Console.WriteLine("ФИО: " + emp.Fio + ". Зарплата: " + emp.Salary);
                    }
                }
            }
            void Zadanie_3_a()
            {
                Console.WriteLine("Вывести З/П меньше, чем: ");
                double arg = Double.Parse(Console.ReadLine());
                foreach (var emp in employees)
                {
                    if (emp.Salary < arg)
                    {
                        Console.WriteLine("ФИО: " + emp.Fio + ". Зарплата: " + emp.Salary);
                    }
                }
            }
            void Zadanie_3_b()
            {
                Console.WriteLine("Вывести З/П больше, чем:  ");
                double arg = Double.Parse(Console.ReadLine());
                foreach (var emp in employees)
                {
                    if (emp.Salary > arg)
                    {
                        Console.WriteLine("ФИО: " + emp.Fio + ". Зарплата: " + emp.Salary);
                    }
                }


            }
        }
    }
}
    

