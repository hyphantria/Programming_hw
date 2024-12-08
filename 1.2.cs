using System;

public class IntegerDivision
{
    public static int Quotient(int a, int b)
    {
        
        if (b <= 0)
        {
            throw new ArgumentException("Делитель должен быть положительным числом.");
        }

        
        if (b == 0)
        {
            throw new DivideByZeroException("Деление на ноль недопустимо.");
        }

        
        if (a == 0) return 0;

        int quotient = 0;
        int remainder = Math.Abs(a); 
        int divisor = b;


        while (remainder >= divisor)
        {
            remainder -= divisor;
            quotient++;
        }

        
        if ((a < 0 && b > 0) || (a > 0 && b < 0))
        {
            quotient = -quotient;
        }

        return quotient;
    }

    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Введите делимое (a):");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите делитель (b):");
            int b = int.Parse(Console.ReadLine());

            int result = Quotient(a, b);
            Console.WriteLine($"Неполное частное от деления {a} на {b}: {result}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: Неверный формат ввода. Введите целые числа.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Ошибка: Переполнение. Введенные числа слишком большие.");
        }
    }
}