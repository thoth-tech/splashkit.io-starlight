using SplashKitSDK;

class Program
{
    static void Main(string[] args)
    {
        // Define a prompt to send to the AI
        string prompt = "What is the capital of France?";
        SplashKit.WriteLine("Prompt: " + prompt);

        // Generate a text response from the AI
        string response = SplashKit.GenerateText(prompt);
        SplashKit.WriteLine("Response: " + response);
    }
}