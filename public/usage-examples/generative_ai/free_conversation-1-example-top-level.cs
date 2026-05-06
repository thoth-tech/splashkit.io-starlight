using static SplashKitSDK.SplashKit;

// Create a conversation instance
Conversation conv = CreateConversation();
WriteLine("Conversation created.");

// Free the conversation to release its resources
FreeConversation(conv);
WriteLine("Conversation freed successfully.");