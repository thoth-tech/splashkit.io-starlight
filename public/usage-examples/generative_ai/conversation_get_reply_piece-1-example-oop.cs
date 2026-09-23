using SplashKitSDK;

namespace ConversationGetReplyPieceExample
{
    public class Program
    {
        public static void Main()
        {
            // Create a conversation using the default language model
            Conversation chat = new Conversation();

            SplashKit.WriteLine("Sending message: \"Explain what AI is in one sentence.\"");
            SplashKit.WriteLine("");

            // Add a user message — the model begins replying immediately
            chat.AddMessage("Explain what AI is in one sentence.");

            // Show a thinking indicator while the model is processing
            if (chat.IsThinking())
            {
                SplashKit.Write("Thinking");
            }

            while (chat.IsThinking())
            {
                SplashKit.Write(".");
                SplashKit.Delay(200);
            }

            // Move to a new line after thinking dots
            SplashKit.WriteLine("");

            SplashKit.Write("AI: ");

            // Stream the reply one piece at a time as it generates
            while (chat.IsReplying())
            {
                // Retrieve the next small piece of the reply (generally one word)
                string piece = chat.GetReplyPiece();
                SplashKit.Write(piece);
            }

            SplashKit.WriteLine("");
            SplashKit.WriteLine("");
            SplashKit.WriteLine("Response complete.");

            // Release conversation resources
            chat.Free();
        }
    }
}
