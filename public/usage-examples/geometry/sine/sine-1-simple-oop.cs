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
            float result = SplashKit.Sine((float)input);

            // Write sine to console
            SplashKit.Write("Sine: ");
            SplashKit.WriteLine(result);
        }
    }
}