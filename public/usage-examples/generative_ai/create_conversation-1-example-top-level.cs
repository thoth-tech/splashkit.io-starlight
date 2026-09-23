using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Create a new conversation using the default language model
Conversation chat = CreateConversation();

string prompt = "What is SplashKit?";
WriteLine("Prompt: " + prompt);

// Add the prompt to the conversation
chat.AddMessage(prompt);

WriteLine("Reply:");

// Retrieve and display the reply one piece at a time
while (chat.IsReplying())
{
    Write(chat.GetReplyPiece());
}

WriteLine("");
WriteLine("Reply complete!");

// Release the conversation resources
chat.Free();