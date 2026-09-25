using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Create a conversation using the default language model
SplashKitSDK.Conversation chat = CreateConversation();

WriteLine("Sending message: \"Explain what AI is in one sentence.\"");
WriteLine("");

// Add a user message — the model begins replying immediately
ConversationAddMessage(chat, "Explain what AI is in one sentence.");

// Show a thinking indicator while the model is processing
if (ConversationIsThinking(chat))
{
    Write("Thinking");
}

while (ConversationIsThinking(chat))
{
    Write(".");
    Delay(200);
}

// Move to a new line after thinking dots
WriteLine("");

Write("AI: ");

// Stream the reply one piece at a time as it generates
while (ConversationIsReplying(chat))
{
    // Retrieve the next small piece of the reply (generally one word)
    string piece = ConversationGetReplyPiece(chat);
    Write(piece);
}

WriteLine("");
WriteLine("");
WriteLine("Response complete.");

// Release conversation resources
FreeConversation(chat);
