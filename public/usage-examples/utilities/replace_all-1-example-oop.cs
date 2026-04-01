using SplashKitSDK;

namespace ReplaceAllExample
{
    public class Program
    {
        public static void Main()
        {
            string sentence = "foo fighters say foo is fun";
            string updatedSentence = SplashKit.ReplaceAll(sentence, "foo", "bar");

            SplashKit.WriteLine("Original: " + sentence);
            SplashKit.WriteLine("Updated: " + updatedSentence);
        }
    }
}
