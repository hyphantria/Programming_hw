using System;

class homework
{
    static void Main()
    {
        Console.WriteLine("Введите первое целое число:");
        int number1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите второе целое число:");
        int number2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите третье целое число:");
        int number3 = int.Parse(Console.ReadLine());

        int result = 0;

        for (int i = 0; i < 32; i++)
        {
            int bit1 = (number1 >> i) & 1;
            int bit2 = (number2 >> i) & 1;
            int bit3 = (number3 >> i) & 1;

            int sum = bit1 + bit2 + bit3;

            if (sum > 1)
            {
                result |= (1 << i);
            }
        }

        Console.WriteLine("Новое число: " + result);
    }
}
