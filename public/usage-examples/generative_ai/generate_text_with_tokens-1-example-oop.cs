using SplashKitSDK;

namespace AIStoryGeneratorExample
{
    public class Program
    {
        public static void Main()
        {
            string prompt = "Once upon a time, there was a robot who";

            SplashKit.WriteLine("Prompt: " + prompt);

            // Generate a continuation of the story, limited to 50 tokens
            string story = SplashKit.GenerateText(prompt, 50);

            SplashKit.WriteLine("Generated story: " + story);
        }
    }
}