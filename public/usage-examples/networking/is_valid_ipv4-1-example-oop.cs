using SplashKitSDK;

namespace IsValidIpv4Example
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.WriteLine("Hello! Welcome to the IPv4 address checker.");

            // Prompt the user for an IP input in dotted decimal format
            SplashKit.WriteLine("Please enter an IPv4 address in dotted decimal format (e.g., 192.168.0.1):");

            // Read the input as a string
            string ipInput = SplashKit.ReadLine();

            // Check the address before trying to use it elsewhere
            bool addressIsValid = SplashKit.IsValidIpv4(ipInput);

            // Tell the user whether the address can be used
            if (addressIsValid)
            {
                SplashKit.WriteLine(ipInput + " is a valid IPv4 address.");
            }
            else
            {
                SplashKit.WriteLine(ipInput + " is not a valid IPv4 address.");
            }
        }
    }
}
