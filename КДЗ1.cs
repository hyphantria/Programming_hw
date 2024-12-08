using System;
using System.Collections.Generic;
using System.Linq;

public class BullsAndCows
{
    public static void Main(string[] args)
    {
        // Загадываем число 
        string secretNumber = "2356";  

        Console.WriteLine("Добро пожаловать в игру \"Быки и коровы\"!");
        Console.WriteLine("Я загадала четырехзначное число. Угадайте его");

        int attempts = 0;
        while (true)
        {
            attempts++;
            Console.Write($"Попытка {attempts}: Введите ваше четырехзначное число: ");
            string guess = Console.ReadLine();

            if (guess.Length != 4 || !guess.All(char.IsDigit) || guess.Distinct().Count() != 4)
            {
                Console.WriteLine("Некорректный ввод. Введите четырехзначное число с различными цифрами.");
                continue;
            }

            int bulls = CountBulls(secretNumber, guess);
            int cows = CountCows(secretNumber, guess);

            Console.WriteLine($"{bulls} бык(а) и {cows} коров(а)");

            if (bulls == 4)
            {
                Console.WriteLine($"Поздравляю! Вы угадали число за {attempts} попыток");
                break;
            }
        }
    }

    // Подсчет быков
    static int CountBulls(string secret, string guess)
    {
        int bulls = 0;
        for (int i = 0; i < 4; i++)
        {
            if (secret[i] == guess[i])
            {
                bulls++;
            }
        }
        return bulls;
    }

    // Подсчет коров
    static int CountCows(string secret, string guess)
    {
        int cows = 0;
        List<char> secretDigits = secret.ToList();
        List<char> guessDigits = guess.ToList();

        for (int i = 0; i < 4; i++)
        {
            if (secretDigits.Contains(guessDigits[i]) && secret[i] != guess[i])
            {
                cows++;
                secretDigits[secretDigits.IndexOf(guessDigits[i])] = ' '; // Избегаем повторного счета
            }
        }
        return cows;
    }
}