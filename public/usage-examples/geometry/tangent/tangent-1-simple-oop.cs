using SplashKitSDK;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.Write("Enter an angle: ");

            // User inputs angle
            double input = SplashKit.ConvertToDouble(SplashKit.ReadLine());
            float result = SplashKit.Tangent((float)input);

            // Write tangent to console
            SplashKit.Write("Tangent: ");
            SplashKit.WriteLine(result);
        }
    }
}