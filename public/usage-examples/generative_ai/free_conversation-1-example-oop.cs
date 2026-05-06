using SplashKitSDK;

namespace FreeConversationExample
{
    public class Program
    {
        public static void Main()
        {
            // Create a conversation instance
            Conversation conv = SplashKit.CreateConversation();
            SplashKit.WriteLine("Conversation created.");

            // Free the conversation to release its resources
            SplashKit.FreeConversation(conv);
            SplashKit.WriteLine("Conversation freed successfully.");
        }
    }
}