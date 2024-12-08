using System;

public class BinaryAddition
{
    
    public static string DecimalToBinary(int decimalNum, int numBits)
    {
        if (decimalNum >= 0)
        {
            
            string binary = Convert.ToString(decimalNum, 2).PadLeft(numBits, '0');
            return binary;
        }
        else
        {
            
            int positiveEquivalent = (1 << numBits) + decimalNum; 
            string binary = Convert.ToString(positiveEquivalent, 2);
            return binary;
        }
    }

    
    public static int BinaryToDecimal(string binary)
    {
        if (binary[0] == '0')
        {
            
            return Convert.ToInt32(binary, 2);
        }
        else
        {
        
            int decimalValue = Convert.ToInt32(binary, 2);
            return decimalValue - (1 << binary.Length); 
        }
    }

    
    public static string AddBinary(string binary1, string binary2)
    {
        int len1 = binary1.Length;
        int len2 = binary2.Length;
        int maxLength = Math.Max(len1, len2);

        
        binary1 = binary1.PadLeft(maxLength, '0');
        binary2 = binary2.PadLeft(maxLength, '0');

        string result = "";
        int carry = 0;

        for (int i = maxLength - 1; i >= 0; i--)
        {
            int sum = (binary1[i] - '0') + (binary2[i] - '0') + carry;
            result = (sum % 2) + result;
            carry = sum / 2;
        }

        if (carry > 0) result = carry + result;
        return result;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Введите первое число:");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        int num2 = int.Parse(Console.ReadLine());

        
        int numBits = 8; 

        
        string binary1 = DecimalToBinary(num1, numBits);
        string binary2 = DecimalToBinary(num2, numBits);

        Console.WriteLine($"\nПервое число ({num1}) в двоичном представлении (дополнительный код): {binary1}");
        Console.WriteLine($"Второе число ({num2}) в двоичном представлении (дополнительный код): {binary2}");


        
        string binarySum = AddBinary(binary1, binary2);

        Console.WriteLine($"\nСложение в столбик:");
        Console.WriteLine($"{binary1}");
        Console.WriteLine($"+{binary2}");
        Console.WriteLine($"={binarySum}");


        
        int decimalSum = BinaryToDecimal(binarySum);

        Console.WriteLine($"\nСумма в десятичном виде: {decimalSum}");
    }
}