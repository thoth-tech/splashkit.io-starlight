using SplashKitSDK;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.WriteLine("Type a phrase in ALL CAPS (SHOUT IT!):");
            string input = SplashKit.ReadLine();

            // Convert input to lowercase
            string quieted = SplashKit.ToLowercase(input);

            SplashKit.WriteLine("Calm down... here it is in lowercase: " + quieted);
        }
    }
}