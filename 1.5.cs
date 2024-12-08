using System;
using System.Linq;

public class Treugolniki
{
    public static bool AreSimilar(double a1, double b1, double c1, double a2, double b2, double c2)
    {
        
        double[] sides1 = { a1, b1, c1 }.OrderBy(x => x).ToArray();
        double[] sides2 = { a2, b2, c2 }.OrderBy(x => x).ToArray();

        
        return Math.Abs(sides1[0] / sides2[0] - sides1[1] / sides2[1]) < 0.001 &&
               Math.Abs(sides1[0] / sides2[0] - sides1[2] / sides2[2]) < 0.001;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Введите длины сторон первого треугольника (a1 b1 c1):");
        string[] input1 = Console.ReadLine().Split();
        double a1 = double.Parse(input1[0]);
        double b1 = double.Parse(input1[1]);
        double c1 = double.Parse(input1[2]);


        Console.WriteLine("Введите длины сторон второго треугольника (a2 b2 c2):");
        string[] input2 = Console.ReadLine().Split();
        double a2 = double.Parse(input2[0]);
        double b2 = double.Parse(input2[1]);
        double c2 = double.Parse(input2[2]);

        Console.WriteLine(AreSimilar(a1, b1, c1, a2, b2, c2) ? "да" : "нет");

    }
}