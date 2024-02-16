using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Select task(1-6): ");
        int task = int.Parse(Console.ReadLine());

        if (task == 1)
        {
            double x1 = 0, y1 = 0; // Вершина 1
            double x2 = 3, y2 = 0; // Вершина 2
            double x3 = 0, y3 = 4; // Вершина 3

            double area = CalculateTriangleArea(x1, y1, x2, y2, x3, y3);
            Console.WriteLine($"Площа трикутника: {area}");
        }
        else if (task == 2)
        {
            Console.Write("Send double digit number: ");
            int number = int.Parse(Console.ReadLine());
            
            Console.Write("Send A: ");
            int A = int.Parse(Console.ReadLine());

            int first = number / 10;
            int second = number % 10;

            int sum = first + second;

            if (A % sum == 0)
            {
                Console.WriteLine("Так, A можна роздiлити нацiло на " + first + " + " + second + " = " + sum);
            }
            else
            {
                Console.WriteLine("Нi, A не можна роздiлити нацiло на " + first + " + " + second + " = " + sum);
            }
        }
        else if (task == 3)
        {
            Console.Write("Send x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Send y: ");
            int y = int.Parse(Console.ReadLine());

            if (x >= -40 && x <= 40 && y >= -40 && y <= 40)
            {
                if (x == -40 || x == 40 || y == -40 || y == 40)
                {
                    Console.WriteLine("На межi");
                }
                else
                {
                    Console.WriteLine("Нi");
                }
            }
            else
            {
                Console.WriteLine("Так");
            }
        }
        else if (task == 4)
        {
            Console.Write("День тижня: ");
            string day = Console.ReadLine();
            
            while(true)
            {
                if (day == "Понедiлок" || day == "Вiвторок" || day == "Середа" || day == "Четвер" || day == "П'ятниця" || day == "Суббота" || day == "Недiля")
                {
                    break;
                }
                else
                {
                    Console.Write("День тижня: ");
                    day = Console.ReadLine();
                }
            }

            if (day == "Понедiлок")
            {
                Console.WriteLine("12:00 - 14:00");
                Console.WriteLine("16:00 - 18:00");
            }
            else if (day == "Вiвторок")
            {
                Console.WriteLine("10:00 - 12:00");
                Console.WriteLine("13:00 - 15:00");
                Console.WriteLine("16:00 - 18:00");
            }
            else if (day == "Середа")
            {
                Console.WriteLine("10:00 - 12:00");
                Console.WriteLine("13:00 - 15:00");
                Console.WriteLine("16:00 - 18:00");
            }
            else if (day == "Четвер")
            {
                Console.WriteLine("10:00 - 12:00");
                Console.WriteLine("13:00 - 15:00");
                Console.WriteLine("16:00 - 18:00");
            }
            else if (day == "П'ятниця")
            {
                Console.WriteLine("12:00 - 14:00");
                Console.WriteLine("16:00 - 18:00");
            }
            else if (day == "Суббота")
            {
                Console.WriteLine("В цей день ми не працюємо");
            }
            else if (day == "Недiля")
            {
                Console.WriteLine("В цей день ми не працюємо");
            }
        }
        else if (task == 5)
        {
            Console.Write("x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y: ");
            int y = int.Parse(Console.ReadLine());

            double square = CalculateTwoNums(x, y);
            Console.WriteLine("Square = " + square);
        }
        else if (task == 6)
        {
            Console.Write("Send m: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Send n: ");
            int n = int.Parse(Console.ReadLine());

            int sum = (m - n) * ((n + 1) / (n + m + 1)) - (n * n) + 5;

            Console.WriteLine("Sum = " + sum);
        }
    }

    static double CalculateTwoNums(double x, double y)
    {
        double quotient = x / y;
        double square = Math.Pow(quotient, 2);
        return square;
    }

    static double CalculateTriangleArea(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        return Math.Abs(0.5 * ((x1 - x3) * (y2 - y3) - (x2 - x3) * (y1 - y3)));
    }
}