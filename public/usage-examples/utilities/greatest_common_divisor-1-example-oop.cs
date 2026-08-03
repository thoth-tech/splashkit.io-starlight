using SplashKitSDK;

namespace GreatestCommonDivisorExample
{
    public class Program
    {
        public static void Main()
        {
            // Find the GCD of 12 and 8
            int result1 = SplashKit.GreatestCommonDivisor(12, 8);
            SplashKit.WriteLine("GCD of 12 and 8 is: " + result1);

            // Find the GCD of 100 and 75
            int result2 = SplashKit.GreatestCommonDivisor(100, 75);
            SplashKit.WriteLine("GCD of 100 and 75 is: " + result2);

            // Find the GCD of 7 and 13 (both prime, so GCD is 1)
            int result3 = SplashKit.GreatestCommonDivisor(7, 13);
            SplashKit.WriteLine("GCD of 7 and 13 is: " + result3);

            // Find the GCD of 36 and 60
            int result4 = SplashKit.GreatestCommonDivisor(36, 60);
            SplashKit.WriteLine("GCD of 36 and 60 is: " + result4);
        }
    }
}
