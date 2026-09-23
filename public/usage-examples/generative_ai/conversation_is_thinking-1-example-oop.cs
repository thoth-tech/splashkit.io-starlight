using SplashKitSDK;

namespace ConversationIsThinkingExample
{
    public class Program
    {
        public static void Main()
        {
            Conversation chat = new Conversation(
                LanguageModel.Qwen306BThinking
            );

            string question = "What is 2 plus 2? Give only the answer.";

            SplashKit.WriteLine("Question: " + question);
            SplashKit.WriteLine("");

            // Send the question to the language model
            chat.AddMessage(question);

            bool thinkingStarted = false;
            bool thinkingFinished = false;
            bool replyHeadingShown = false;

            while (chat.IsReplying())
            {
                bool isThinking = chat.IsThinking();

                // Display messages when the thinking state changes
                if (isThinking && !thinkingStarted)
                {
                    SplashKit.WriteLine("The model is thinking...");
                    thinkingStarted = true;
                }

                if (
                    !isThinking &&
                    thinkingStarted &&
                    !thinkingFinished
                )
                {
                    SplashKit.WriteLine("Thinking done.");
                    thinkingFinished = true;
                }

                string replyPiece = chat.GetReplyPiece();

                if (!isThinking)
                {
                    if (!replyHeadingShown)
                    {
                        SplashKit.WriteLine("");
                        SplashKit.WriteLine("Final reply:");
                        replyHeadingShown = true;
                    }

                    SplashKit.Write(replyPiece);
                }
            }

            SplashKit.WriteLine("");
            SplashKit.WriteLine("");
            SplashKit.WriteLine("Reply complete.");

            chat.Free();
        }
    }
}