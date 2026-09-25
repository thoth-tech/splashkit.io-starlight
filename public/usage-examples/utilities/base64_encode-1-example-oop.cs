using SplashKitSDK;

namespace Base64EncodeExample
{
    public class Program
    {
        public static void Main()
        {
            string input = "Hello World";
            string encoded = SplashKit.Base64Encode(input);

            SplashKit.WriteLine("Original: " + input);
            SplashKit.WriteLine("Encoded: " + encoded);
        }
    }
}