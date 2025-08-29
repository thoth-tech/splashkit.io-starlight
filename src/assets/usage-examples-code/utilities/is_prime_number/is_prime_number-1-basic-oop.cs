// I am reading an integer and printing whether it is prime using is_prime_number.
using System;
using SplashKitSDK;

namespace PrimeCheckExample
{
    public static class Program
    {
        public static void Main()
        {
            Console.Write("Enter an integer: ");
            int n = int.TryParse(Console.ReadLine(), out var v) ? v : 0;

            bool prime = SplashKit.IsPrimeNumber(n);
            Console.WriteLine($"{n} {(prime ? "is prime" : "is not prime")}");
        }
    }
}