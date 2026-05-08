using SplashKitSDK;

namespace GenerateTextExample
{
    public class Program
    {
        public static void Main()
        {
            // Prompt sent to the AI model
            string prompt = "Give me a fun fact about space.";

            // Generate a text response from the AI
            string response = SplashKit.GenerateText(prompt);

            // Display the prompt and response
            SplashKit.WriteLine("Prompt: " + prompt);
            SplashKit.WriteLine("");
            SplashKit.WriteLine("AI Response:");
            SplashKit.WriteLine(response);
        }
    }
}
