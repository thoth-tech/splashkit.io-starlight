using SplashKitSDK;

namespace GenerateTextExample
{
    public class Program
    {
        public static void Main()
        {
            // Define a prompt to send to the AI
            // Note: Requires a local AI model to be set up via SplashKit
            string prompt = "What is the capital of France?";
            SplashKit.WriteLine("Prompt: " + prompt);

            // Generate a text response from the AI
            string response = SplashKit.GenerateText(prompt);
            SplashKit.WriteLine("Response: " + response);
        }
    }
}