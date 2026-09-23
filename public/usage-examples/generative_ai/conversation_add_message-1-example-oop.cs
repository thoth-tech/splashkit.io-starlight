using SplashKitSDK;

namespace AINPCDialogueExample
{
    public class Program
    {
        private static string GetFullReply(Conversation conv)
        {
            string reply = "";

            while (conv.IsReplying())
            {
                reply += conv.GetReplyPiece();
            }

            return reply;
        }

        public static void Main()
        {
            SplashKit.WriteLine("=== Splashwood Village Guide ===");
            SplashKit.WriteLine("");

            // Create one conversation so the NPC keeps the conversation context
            Conversation guide = SplashKit.CreateConversation();

            string rolePrompt =
                "You are Rowan, a friendly village guide in Splashwood Village. " +
                "Stay in character and keep your answers short and helpful. " +
                "Splashwood Village has a market in the village square, " +
                "an old forest to the north, and an inn beside the fountain.";

            guide.AddMessage(rolePrompt);

            // Consume the setup response before continuing
            GetFullReply(guide);

            string firstQuestion = "Where can I buy supplies?";
            SplashKit.WriteLine("Player: " + firstQuestion);

            guide.AddMessage(firstQuestion);
            string firstReply = GetFullReply(guide);

            SplashKit.WriteLine("Rowan: " + firstReply);
            SplashKit.WriteLine("");

            string secondQuestion = "Where is that from here?";
            SplashKit.WriteLine("Player: " + secondQuestion);

            guide.AddMessage(secondQuestion);
            string secondReply = GetFullReply(guide);

            SplashKit.WriteLine("Rowan: " + secondReply);
            SplashKit.WriteLine("");

            string thirdQuestion = "Is there anywhere dangerous I should avoid?";
            SplashKit.WriteLine("Player: " + thirdQuestion);

            guide.AddMessage(thirdQuestion);
            string thirdReply = GetFullReply(guide);

            SplashKit.WriteLine("Rowan: " + thirdReply);

            guide.Free();
        }
    }
}