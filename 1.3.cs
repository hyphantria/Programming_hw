using System;

public class QuadraticEquationSolver
{
    public static void SolveQuadraticEquation(double a, double b, double c)
    {
        if (a == 0)
        {
            
            if (b == 0)
            {
                if (c == 0)
                {
                    Console.WriteLine("Уравнение имеет бесконечно много решений.");
                }
                else
                {
                    Console.WriteLine("Уравнение не имеет решений.");
                }
            }
            else
            {
                double x = -c / b;
                Console.WriteLine($"Уравнение имеет одно решение: x = {x}");
            }
        }
        else
        {
            
            double discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
            {
                Console.WriteLine("Уравнение не имеет действительных решений.");
            }
            else if (discriminant == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Уравнение имеет одно решение: x = {x}");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine($"Уравнение имеет два решения: x1 = {x1}, x2 = {x2}");
            }
        }
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Введите коэффициент a:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите коэффициент b:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите коэффициент c:");
        double c = double.Parse(Console.ReadLine());

        SolveQuadraticEquation(a, b, c);
    }
}