using SplashKitSDK;

namespace IsNumberExample
{
    public class Program
    {
        public static void Main()
        {
            // Check if "42" is a number
            bool result1 = SplashKit.IsNumber("42");
            SplashKit.WriteLine("Is '42' a number? " + result1);

            // Check if "3.14" is a number
            bool result2 = SplashKit.IsNumber("3.14");
            SplashKit.WriteLine("Is '3.14' a number? " + result2);

            // Check if "hello" is a number
            bool result3 = SplashKit.IsNumber("hello");
            SplashKit.WriteLine("Is 'hello' a number? " + result3);

            // Check if "12abc" is a number
            bool result4 = SplashKit.IsNumber("12abc");
            SplashKit.WriteLine("Is '12abc' a number? " + result4);
        }
    }
}
