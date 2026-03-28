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
            float result = SplashKit.Cosine((float)input);

            // Write cosine to console
            SplashKit.Write("Cosine: ");
            SplashKit.WriteLine(result);
        }
    }
}