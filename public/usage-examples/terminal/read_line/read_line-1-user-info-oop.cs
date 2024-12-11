using SplashKitSDK;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.WriteLine("Enter your name:");

            // Read the user input
            string name = SplashKit.ReadLine();

            // Output a greeting
            SplashKit.WriteLine("Hello, " + name + "!");

            SplashKit.WriteLine();

            SplashKit.WriteLine("Enter your age:");

            // Read the user input
            string age = SplashKit.ReadLine();

            // Output the age
            SplashKit.WriteLine("You are " + age + " years old.");

            SplashKit.WriteLine();

            SplashKit.WriteLine("Enter your favorite colour:");

            // Read the user input
            string colour = SplashKit.ReadLine();

            // Output the favourite colour
            SplashKit.WriteLine("Your favourite color is " + colour + ".");
        }
    }
}