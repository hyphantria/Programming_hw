using System;
using System.Linq;

public class TicTacToe
{
    private static char[,] board = new char[3, 3];
    private static char currentPlayer = 'X';
    private static bool isPlayerVsComputer = false;


    private static void InitializeBoard()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                board[i, j] = ' ';
            }
        }
    }

    private static void PrintBoard()
    {
        Console.WriteLine("  1 2 3");
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"{i + 1} ");
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"{board[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    private static bool MakeMove(int row, int col)
    {
        if (row < 1 || row > 3 || col < 1 || col > 3 || board[row - 1, col - 1] != ' ')
        {
            Console.WriteLine("Неверный ход. Попробуйте еще раз.");
            return false;
        }
        board[row - 1, col - 1] = currentPlayer;
        return true;
    }

    private static bool CheckWin()
    {
        for (int i = 0; i < 3; i++)
        {
            if (board[i, 0] != ' ' && board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2]) return true;
            if (board[0, i] != ' ' && board[0, i] == board[1, i] && board[1, i] == board[2, i]) return true;
        }
        if (board[0, 0] != ' ' && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2]) return true;
        if (board[0, 2] != ' ' && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0]) return true;
        return false;
    }

    private static bool CheckDraw()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (board[i, j] == ' ') return false;
            }
        }
        return true;
    }

    private static void ComputerMove()
    {
        // Simple computer AI:  chooses a random available spot
        Random random = new Random();
        int row, col;
        do
        {
            row = random.Next(1, 4);
            col = random.Next(1, 4);
        } while (!MakeMove(row, col));
        Console.WriteLine($"Компьютер сделал ход: {row},{col}");

    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Выберите режим игры:");
        Console.WriteLine("1. Игрок против игрока");
        Console.WriteLine("2. Игрок против компьютера");
        int choice = int.Parse(Console.ReadLine());
        isPlayerVsComputer = choice == 2;

        InitializeBoard();

        while (true)
        {
            PrintBoard();
            Console.WriteLine($"Ход игрока {currentPlayer}");

            if (currentPlayer == 'O' && isPlayerVsComputer)
            {
                ComputerMove();
            }
            else
            {
                Console.Write("Введите номер строки (1-3): ");
                int row = int.Parse(Console.ReadLine());
                Console.Write("Введите номер столбца (1-3): ");
                int col = int.Parse(Console.ReadLine());
                MakeMove(row, col);
            }


            if (CheckWin())
            {
                PrintBoard();
                Console.WriteLine($"Игрок {currentPlayer} выиграл!");
                break;
            }
            else if (CheckDraw())
            {
                PrintBoard();
                Console.WriteLine("Ничья!");
                break;
            }
            currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
        }
    }
}