using SplashKitSDK;

namespace MacToHexExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.WriteLine("Hello! Welcome to the MAC address to hexadecimal converter.");

            // Prompt the user for a MAC address in XX:XX:XX:XX:XX:XX format
            SplashKit.WriteLine("Please enter a MAC address (e.g., 1A:2B:3C:4D:5E:6F):");

            // Read the input as a string
            string macInput = SplashKit.ReadLine();

            // Convert the MAC address to hexadecimal format
            string macAsHex = SplashKit.MacToHex(macInput);

            // Display the result
            SplashKit.WriteLine("The MAC address in hexadecimal format is: " + macAsHex);
        }
    }
}
