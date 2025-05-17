using SplashKitSDK;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.WriteLine("Welcome to the hexadecimal to ipv4 converter.");

            // Prompt the user for a hexadecimal input
            SplashKit.WriteLine("Please enter a hexadecimal number:");

            // Read the input as a string
            string hex_input = SplashKit.ReadLine();

            // Convert the hexadecimal string to ipv4
            string ipv4_value = SplashKit.HexStrToIpv4(hex_input);

            // Display the result
            SplashKit.WriteLine("The hexadecimal value in ipv4 format is: " + ipv4_value);
        }
    }
}