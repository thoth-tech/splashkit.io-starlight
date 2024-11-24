using SplashKitSDK;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.WriteLine("Welcome to the Terminal Input Checker!");
            SplashKit.WriteLine("Type something and press Enter to see it echoed back.");
            SplashKit.WriteLine("Type 'exit' and press Enter to quit the program.");

            while (true)
            {
                // Check if there's input waiting in the terminal
                if (SplashKit.TerminalHasInput())
                {
                    // Read and echo the input
                    string input = SplashKit.ReadLine();
                    if (input == "exit")
                    {
                        SplashKit.WriteLine("Exiting the program...");
                        break;
                    }
                    SplashKit.WriteLine("You typed: " + input);
                }
            }
        }
    }
}