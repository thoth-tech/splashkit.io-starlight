using SplashKitSDK;

namespace SquareRootExample
{
    public class Program
    {
        public static void Main()
        {
            // Find the square root of 25
            double result1 = SplashKit.SquareRoot(25);
            SplashKit.WriteLine("Square root of 25 is: " + result1);

            // Find the square root of 144
            double result2 = SplashKit.SquareRoot(144);
            SplashKit.WriteLine("Square root of 144 is: " + result2);

            // Find the square root of 2 (irrational)
            double result3 = SplashKit.SquareRoot(2);
            SplashKit.WriteLine("Square root of 2 is: " + result3);

            // Find the square root of 0
            double result4 = SplashKit.SquareRoot(0);
            SplashKit.WriteLine("Square root of 0 is: " + result4);
        }
    }
}
