using System;

class Program
{
    static void Main()
    {/*
      //Count Down from 10 - 1
        Console.WriteLine("Count Down from 10 to 1: ");
        for (int i = 10; i >= 1; i--)
        {
            Console.WriteLine(i);
        }*/

        //Print Odd Numbers
        /*Console.WriteLine("Odd numbers: ");
        for (int i = 1; i <= 50; i++)
        {
            if (i % 2 != 0)
                Console.Write( i + " ");
        }
        */

        /*
        //Power of a Number
        int baseNum2 = 2, exp2 = 5;
        int result2 = 1, i2 = 1;
        while (i2 <= exp2)
        {
            result2 *= baseNum2;
            i2++;
        }
        Console.WriteLine($"Power: {result2}");
        /*



        /*
        //Sum of Squares
        int sum1 = 0;
        for (int i = 1; i <= 10; i++)
        {
            sum1 += i * i;
        }
        Console.WriteLine($"Sum of squares: {sum1}");
        */


        //Sum of Odd Digits
        int number3 = 57382;
        int sumOdd3 = 0;
        int n3 = number3;

        do
        {
            int digit = n3 % 10;
            if (digit % 2 != 0)
                sumOdd3 += digit;
            n3 /= 10;
        } while (n3 > 0);

        Console.WriteLine($"Sum of odd digits: {sumOdd3}");

    }
}
