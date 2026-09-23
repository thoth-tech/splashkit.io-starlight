using SplashKitSDK;

namespace CreateConversationExample
{
    public class Program
    {
        public static void Main()
        {
            // Create a new conversation using the default language model
            Conversation chat = new Conversation();

            string prompt = "What is SplashKit?";
            SplashKit.WriteLine("Prompt: " + prompt);

            // Add the prompt to the conversation
            chat.AddMessage(prompt);

            SplashKit.WriteLine("Reply:");

            // Retrieve and display the reply one piece at a time
            while (chat.IsReplying())
            {
                SplashKit.Write(chat.GetReplyPiece());
            }

            SplashKit.WriteLine("");
            SplashKit.WriteLine("Reply complete!");

            // Release the conversation resources
            chat.Free();
        }
    }
}