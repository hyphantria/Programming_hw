using System;

public class CirclePrinterSimple
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите радиус окружности:");
        int radius = int.Parse(Console.ReadLine());

        for (int i = -radius; i <= radius; i++)
        {
            for (int j = -radius; j <= radius; j++)
            {
                if (Math.Sqrt(i * i + j * j) <= radius + 0.5) 
                
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}