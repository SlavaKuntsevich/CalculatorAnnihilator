using System.Net.Sockets;

namespace CalculatorAnnihilator
{
    internal class Program
    {
        static void Main(string[] args)
        {
             
            while (true)
            {
                Console.WriteLine("Добро пожаловать в калькулятор!");
                Console.WriteLine("Выберите арифметическую операцию:");
                Console.WriteLine("1.Сложение");
                Console.WriteLine("2.Вычитание");
                Console.WriteLine("3.Деление");
                Console.WriteLine("4.Умножение");
                Console.WriteLine("5.Процент от числа");
                Console.WriteLine("6.Квадратный корень числа");
                double a = double.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Console.WriteLine("Введите первую циферку:");
                        double b = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите вторую циферку:");
                        double c = double.Parse(Console.ReadLine());
                        double d = b + c;
                        Console.WriteLine($"Ответ убил:{d}");
                        break;
                        case 2:
                        Console.WriteLine("Введите первую циферку:");
                        b = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите вторую циферку:");
                        c = double.Parse(Console.ReadLine());
                        d = b - c;
                        Console.WriteLine($"Ответ убил:{d}");
                        break;
                        case 3:
                        Console.WriteLine("Введите первую циферку:");
                        b = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите вторую циферку:");
                        c = double.Parse(Console.ReadLine());
                        d = b / c;
                        Console.WriteLine($"Ответ убил:{d}");
                        if (b == 0 || c == 0)
                            Console.WriteLine("На ноль делить нельзя");
                        break;
                        case 4:
                        Console.WriteLine("Введите первую циферку:");
                        b = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите вторую циферку:");
                        c = double.Parse(Console.ReadLine());
                        d = b * c;
                        Console.WriteLine($"Ответ убил:{d}");
                        break;
                        case 5:
                        Console.WriteLine("Введите первую циферку:");
                        b = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите вторую циферку:");
                        c = double.Parse(Console.ReadLine());
                        d = (c /100 ) * b ;
                        Console.WriteLine($"Ответ убил:{d}");
                        break;
                        case 6:
                        Console.WriteLine("Введите число:");
                        b = double.Parse(Console.ReadLine());
                        d = Convert.ToDouble(Math.Sqrt(b));
                        Console.WriteLine($"Ответ убил:{d}");
                        break;
                        
                        
                        
                         
                }
                

            }
        }
    }
}