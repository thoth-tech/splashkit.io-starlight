using SplashKitSDK;

namespace GCDExample
{
    public class Program
    {
        public static void Main()
        {
            // open window
            SplashKit.OpenWindow("Greatest Common Divisor Example", 640, 360);

            // define two numbers
            int numA = 48;
            int numB = 18;

            // calculate gcd using splashkit function
            int result = SplashKit.GCD(numA, numB);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen(Color.White);

                // heading
                SplashKit.DrawText("Calculating the Greatest Common Divisor (GCD)", Color.Blue, 60, 40);

                // numbers
                SplashKit.DrawText($"Number A: {numA}", Color.Black, 80, 100);
                SplashKit.DrawText($"Number B: {numB}", Color.Black, 80, 140);

                // result
                SplashKit.DrawText($"GCD Result: {result}", Color.Red, 80, 200);

                // exit instructions
                SplashKit.DrawText("Press ESC to exit", Color.Gray, 420, 330);

                SplashKit.RefreshScreen();
            }

            SplashKit.CloseAllWindows();
        }
    }
}
