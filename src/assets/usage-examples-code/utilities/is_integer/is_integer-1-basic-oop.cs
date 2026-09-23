// Usage Example for: https://splashkit.io/api/text/#is-integer
// Goal: I am reading text and I am printing whether each line is an integer.
// Why: I am showing how to use IsInteger inside a small class.
// Controls: I am typing q or quit to exit.

using SplashKitSDK;

namespace UtilitiesExamples
{
    public class IsIntegerRepl
    {
        public void Run()
        {
            SplashKit.WriteLine("Is Integer Checker (OOP)");
            SplashKit.WriteLine("Type a value and press Enter. Type q to quit.");

            bool running = true;
            while (running)
            {
                SplashKit.Write("> ");
                string? text = SplashKit.ReadLine();

                if (text == null)
                {
                    break;
                }

                if (text == "q" || text == "quit")
                {
                    running = false;
                }
                else
                {
                    // I am using IsInteger so I am learning the utility call
                    if (SplashKit.IsInteger(text))
                    {
                        SplashKit.WriteLine("Integer");
                    }
                    else
                    {
                        SplashKit.WriteLine("Not integer");
                    }
                }
            }

            SplashKit.WriteLine("Bye");
        }

        public static void Main()
        {
            new IsIntegerRepl().Run();
        }
    }
}