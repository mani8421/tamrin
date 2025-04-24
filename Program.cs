using System;

class Program
{
    static void Main()
    {
        int n;
        Console.Write("student: ");
        n = int.Parse(Console.ReadLine());

        int[] studentNumbers = new int[n];
        int[] majorCodes = new int[n];

        int i = 0;
        while (i < n)
        {
            Console.Write("student number " + (i + 1) + ": ");
            studentNumbers[i] = int.Parse(Console.ReadLine());

            Console.Write("reshte" + (i + 1) + ": ");
            majorCodes[i] = int.Parse(Console.ReadLine());

            i = i + 1;
        }

        Console.WriteLine();
        Console.WriteLine("tafkik:");

        int code = 1;
        while (code <= 10)
        {
            Console.WriteLine("reshte ba kode " + code + ":");

            int j = 0;
            while (j < n)
            {
                if (majorCodes[j] == code)
                {
                    Console.WriteLine("  student number: " + studentNumbers[j]);
                }
                j = j + 1;
            }

            code = code + 1;
        }
    }
}