using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {

            double a;
            double b;
            double total;
            char oper;
            Console.WriteLine("Добрый день, Вы в консольном калькуляторе");
            Console.WriteLine("Введите первое число:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите оператор:");
            oper = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            b = Convert.ToDouble(Console.ReadLine());
            if (oper == '+')
            {
                total = a + b;
                Console.WriteLine("Cумма " + a + " и " + b + " равна " + total + ".");
            }

            else if (oper == '-')
            {
                total = a - b;
                Console.WriteLine("Разность " + a + " и " + b + " равна " + total + ".");
            }

            else if (oper == '*')
            {
                total = a * b;
                Console.WriteLine("Умножение " + a + " на " + b + " равно " + total + ".");
            }

            else if (oper == '/')
            {
                if (b != 0)
                {
                    total = a / b;
                    Console.WriteLine("Деление " + a + " на " + b + " равно " + total + ".");
                }
                else
                {
                    Console.WriteLine("Деление на ноль!!!");
                }
            }
            else if (oper == '^')
            {
                    total = Math.Pow(a, b);
                    Console.WriteLine("Возведение " + a + " в степень " + b + " равно " + total + ".");
            }
            else if (oper == '~')
            {
                total = Math.Pow(a, 1/b);
                Console.WriteLine("Извлечение корня степени " + b + " из числа " + a + " равно " + total + ".");
            }
            else
            {
                Console.WriteLine("Неизвестный оператор.");
            }




        }
    }
}
