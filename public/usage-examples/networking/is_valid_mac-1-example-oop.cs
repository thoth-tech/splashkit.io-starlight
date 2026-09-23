using SplashKitSDK;

namespace IsValidMacExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.WriteLine("Hello! Welcome to the MAC address checker.");

            // Prompt the user for a MAC address in XX:XX:XX:XX:XX:XX format
            SplashKit.WriteLine("Please enter a MAC address (e.g., 1A:2B:3C:4D:5E:6F):");

            // Read the input as a string
            string macInput = SplashKit.ReadLine();

            // Check the address before trying to convert or store it
            bool addressIsValid = SplashKit.IsValidMac(macInput);

            // Tell the user whether the address can be used
            if (addressIsValid)
            {
                SplashKit.WriteLine(macInput + " is a valid MAC address.");
            }
            else
            {
                SplashKit.WriteLine(macInput + " is not a valid MAC address.");
            }
        }
    }
}
