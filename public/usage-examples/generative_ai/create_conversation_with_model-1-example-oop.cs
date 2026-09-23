using SplashKitSDK;

namespace AIModelComparisonExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.WriteLine("Prompt: What is AI?");
            SplashKit.WriteLine("");

            // Create a conversation using the Qwen3 model, and send the prompt to it
            SplashKit.WriteLine("Asking Qwen3 1.7B Instruct...");
            Conversation qwenChat = new Conversation(LanguageModel.Qwen317BInstruct);
            qwenChat.AddMessage("What is AI?");
            string qwenReply = qwenChat.GetReply();
            SplashKit.WriteLine("Qwen3 reply: " + qwenReply);
            SplashKit.WriteLine("");

            // Create a conversation using the Gemma3 model, and send the same prompt to it
            SplashKit.WriteLine("Asking Gemma3 1B Instruct...");
            Conversation gemmaChat = new Conversation(LanguageModel.Gemma31BInstruct);
            gemmaChat.AddMessage("What is AI?");
            string gemmaReply = gemmaChat.GetReply();
            SplashKit.WriteLine("Gemma3 reply: " + gemmaReply);

            // Release the resources used by both conversations
            qwenChat.Free();
            gemmaChat.Free();
        }
    }
}