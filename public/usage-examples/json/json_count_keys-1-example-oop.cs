using SplashKitSDK;

namespace JsonCountKeysExample
{
    public class Program
    {
        public static void Main()
        {
            Json j = new Json();

            j.AddString("name", "Alex");
            j.AddString("score", "95");
            j.AddString("level", "3");

            Console.WriteLine($"Top-level key count: {j.CountKeys()}");
        }
    }
}