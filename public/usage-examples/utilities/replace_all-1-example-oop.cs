using SplashKitSDK;

namespace ReplaceAllExample
{
    public class Program
    {
        public static void Main()
        {
            string text = "I like cats. cats are great. I have two cats.";
            SplashKit.WriteLine("Original: " + text);

            // Replace all occurrences of "cats" with "dogs"
            string result = SplashKit.ReplaceAll(text, "cats", "dogs");
            SplashKit.WriteLine("Replaced: " + result);

            string greeting = "Hello World! Hello Everyone!";
            SplashKit.WriteLine("\nOriginal: " + greeting);

            // Replace all occurrences of "Hello" with "Hi"
            string newGreeting = SplashKit.ReplaceAll(greeting, "Hello", "Hi");
            SplashKit.WriteLine("Replaced: " + newGreeting);
        }
    }
}
