using static SplashKitSDK.SplashKit;

// Create three conversation instances
Conversation conv1 = CreateConversation();
Conversation conv2 = CreateConversation();
Conversation conv3 = CreateConversation();

WriteLine("Created 3 conversations.");

// Free individual conversations
FreeConversation(conv1);
WriteLine("Freed conversation 1.");

FreeConversation(conv2);
WriteLine("Freed conversation 2.");

// Free all remaining conversations at once
FreeAllConversations();
WriteLine("Freed all remaining conversations.");
WriteLine("All AI resources have been released.");
