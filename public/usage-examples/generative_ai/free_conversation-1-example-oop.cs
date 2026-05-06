using SplashKitSDK;

namespace FreeConversationExample
{
    public class Program
    {
        public static void Main()
        {
            // Create three conversation instances
            Conversation conv1 = SplashKit.CreateConversation();
            Conversation conv2 = SplashKit.CreateConversation();
            Conversation conv3 = SplashKit.CreateConversation();

            SplashKit.WriteLine("Created 3 conversations.");

            // Free individual conversations
            SplashKit.FreeConversation(conv1);
            SplashKit.WriteLine("Freed conversation 1.");

            SplashKit.FreeConversation(conv2);
            SplashKit.WriteLine("Freed conversation 2.");

            // Free all remaining conversations at once
            SplashKit.FreeAllConversations();
            SplashKit.WriteLine("Freed all remaining conversations.");
            SplashKit.WriteLine("All AI resources have been released.");
        }
    }
}
