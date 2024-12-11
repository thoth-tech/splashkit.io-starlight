using SplashKitSDK;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.WriteLine("Check the ASCII value of a character.");
            SplashKit.WriteLine("Press 'q' to quit, or type any character to see its ASCII value.");

            while (true)
            {
                SplashKit.Write("Enter a character: ");
                char input = SplashKit.ReadChar(); // Read a single character input

                if (input == 'q') // Quit if 'q' is pressed
                {
                    SplashKit.WriteLine("You pressed 'q'. Exiting the program. Goodbye!");
                    break;
                }
                else
                {
                    // Display the ASCII value of the character
                    SplashKit.WriteLine($"You pressed '{input}' (ASCII: {(int)input}).");
                }
            }
        }
    }
}