using System;
public class Program
{
    public static void Main()
    {
        int i, j;
        bool isPrime;

        // Print the first two prime numbers
        Console.WriteLine("2\n3");

        // Loop through all odd numbers starting from 5 up to 3000
        for (i = 5; i <= 3000; i += 2)
        {
            // Assume the current number is prime
            isPrime = true;

            // Loop through all odd numbers from 3 up to the square root of the current number
            for (j = 3; j <= Math.Sqrt(i); j += 2)
            {
                // If the current number is divisible by any number other than 1 and itself, it is not prime
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            // If the current number is prime, print it
            if (isPrime)
            {
                Console.WriteLine(i);
            }
        }
    }
}
