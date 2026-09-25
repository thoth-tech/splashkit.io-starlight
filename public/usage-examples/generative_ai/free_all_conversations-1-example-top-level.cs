using SplashKitSDK;
using static SplashKitSDK.SplashKit;

Conversation studyConversation = CreateConversation();
Conversation travelConversation = CreateConversation();
Conversation codingConversation = CreateConversation();

WriteLine("Three AI conversations have been created:");
WriteLine("- Study assistant");
WriteLine("- Travel assistant");
WriteLine("- Coding assistant");
WriteLine("");

WriteLine("Freeing all loaded conversations...");

GenerativeAi.FreeAll();

WriteLine("All conversation resources have been released.");
