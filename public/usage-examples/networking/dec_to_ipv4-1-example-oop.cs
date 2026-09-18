using System;
using SplashKitSDK;

namespace DecToIpv4Example
{
    public class Program
    {
        public static void Main()
        {
            uint firstIp = 2130706433;
            uint secondIp = 3232235777;
            uint thirdIp = 134744072;

            // Convert decimal IP values into IPv4 addresses
            string firstAddress = SplashKit.DecToIpv4(firstIp);
            string secondAddress = SplashKit.DecToIpv4(secondIp);
            string thirdAddress = SplashKit.DecToIpv4(thirdIp);

            Console.WriteLine("Decimal to IPv4 Conversion");
            Console.WriteLine();

            Console.WriteLine(firstIp + " -> " + firstAddress);
            Console.WriteLine(secondIp + " -> " + secondAddress);
            Console.WriteLine(thirdIp + " -> " + thirdAddress);
        }
    }
}