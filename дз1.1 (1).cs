using System;
namespace homework
{

    class Program
    {
        static void Main()
        {

            Console.Write("Vvedite chislo: ");
            int chislo = Convert.ToInt32(Console.ReadLine());
            for (int i = 1, count = 0; i <= chislo; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count+=1;
                    }
                }
                if (count <= 2)
                {
                    Console.WriteLine(i);
                }

                count = 0;
            }
        }
    }
}
