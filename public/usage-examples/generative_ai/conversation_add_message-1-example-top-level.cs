using SplashKitSDK;
using static SplashKitSDK.SplashKit;

string GetFullReply(Conversation conv)
{
    string reply = "";

    while (conv.IsReplying())
    {
        reply += conv.GetReplyPiece();
    }

    return reply;
}

WriteLine("=== Splashwood Village Guide ===");
WriteLine("");

// Create one conversation so the NPC keeps the conversation context
Conversation guide = CreateConversation();

string rolePrompt =
    "You are Rowan, a friendly village guide in Splashwood Village. " +
    "Stay in character and keep your answers short and helpful. " +
    "Splashwood Village has a market in the village square, " +
    "an old forest to the north, and an inn beside the fountain.";

guide.AddMessage(rolePrompt);

// Consume the setup response before continuing
GetFullReply(guide);

string firstQuestion = "Where can I buy supplies?";
WriteLine("Player: " + firstQuestion);

guide.AddMessage(firstQuestion);
string firstReply = GetFullReply(guide);

WriteLine("Rowan: " + firstReply);
WriteLine("");

string secondQuestion = "Where is that from here?";
WriteLine("Player: " + secondQuestion);

guide.AddMessage(secondQuestion);
string secondReply = GetFullReply(guide);

WriteLine("Rowan: " + secondReply);
WriteLine("");

string thirdQuestion = "Is there anywhere dangerous I should avoid?";
WriteLine("Player: " + thirdQuestion);

guide.AddMessage(thirdQuestion);
string thirdReply = GetFullReply(guide);

WriteLine("Rowan: " + thirdReply);

guide.Free();