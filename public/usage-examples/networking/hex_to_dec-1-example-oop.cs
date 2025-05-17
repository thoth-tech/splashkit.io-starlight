using SplashKitSDK;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.WriteLine("Welcome to the hexadecimal to Dec converter.");

            // Prompt the user for a hexadecimal input
            SplashKit.WriteLine("Please enter a hexadecimal number:");

            // Read the input as a string
            string hex_input = SplashKit.ReadLine();

            // Convert the hexadecimal string to dec
            string dec_value = SplashKit.HexToDecString(hex_input);

            // Display the result
            SplashKit.WriteLine("The hexadecimal value in dec format is: " + dec_value);
        }
    }
}