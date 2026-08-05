using SplashKitSDK;
using System.Collections.Generic;

namespace SplitExample
{
    public class Program
    {
        public static void Main()
        {
            // Split a CSV string by comma
            List<string> parts = SplashKit.Split("apple,banana,cherry,date", ',');
            SplashKit.WriteLine("Split 'apple,banana,cherry,date' by ',':");
            for (int i = 0; i < parts.Count; i++)
            {
                SplashKit.WriteLine("  [" + i + "] " + parts[i]);
            }

            // Split a sentence by space
            List<string> words = SplashKit.Split("Hello World SplashKit", ' ');
            SplashKit.WriteLine("Split 'Hello World SplashKit' by ' ':");
            for (int i = 0; i < words.Count; i++)
            {
                SplashKit.WriteLine("  [" + i + "] " + words[i]);
            }

            // Split a path by slash
            List<string> folders = SplashKit.Split("home/user/documents", '/');
            SplashKit.WriteLine("Split 'home/user/documents' by '/':");
            for (int i = 0; i < folders.Count; i++)
            {
                SplashKit.WriteLine("  [" + i + "] " + folders[i]);
            }
        }
    }
}
