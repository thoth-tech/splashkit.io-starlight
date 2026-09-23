using SplashKitSDK;

namespace FreeAllConversationsExample
{
    public class Program
    {
        public static void Main()
        {
            Conversation studyConversation = SplashKit.CreateConversation();
            Conversation travelConversation = SplashKit.CreateConversation();
            Conversation codingConversation = SplashKit.CreateConversation();

            SplashKit.WriteLine("Three AI conversations have been created:");
            SplashKit.WriteLine("- Study assistant");
            SplashKit.WriteLine("- Travel assistant");
            SplashKit.WriteLine("- Coding assistant");
            SplashKit.WriteLine("");

            SplashKit.WriteLine("Freeing all loaded conversations...");

            GenerativeAi.FreeAll();

            SplashKit.WriteLine("All conversation resources have been released.");
        }
    }
}
