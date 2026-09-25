using SplashKitSDK;

namespace DecToIpv4Example
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.WriteLine("Hello! Welcome to the decimal to IPv4 converter.");

            // Prompt the user for a decimal input
            SplashKit.WriteLine("Please enter a decimal number (e.g., 2130706433):");

            // Read the input as a string
            string decInput = SplashKit.ReadLine();

            // Convert the input string to an unsigned integer
            uint decValue = Convert.ToUInt32(decInput);

            // Convert the decimal value to a dotted decimal IPv4 address
            string ipAddress = SplashKit.DecToIpv4(decValue);

            // Display the result
            SplashKit.WriteLine("The decimal value as an IPv4 address is: " + ipAddress);
        }
    }
}
