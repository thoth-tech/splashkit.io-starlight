using SplashKitSDK;
using static SplashKitSDK.SplashKit;

string prompt = "What is AI?";

WriteLine("Prompt: " + prompt);
WriteLine("");

// Create a conversation using the Qwen3 model, and send the prompt to it
WriteLine("Asking Qwen3 1.7B Instruct...");
Conversation qwenChat = new Conversation(LanguageModel.Qwen317BInstruct);
qwenChat.AddMessage(prompt);
string qwenReply = qwenChat.GetReply();
WriteLine("Qwen3 reply: " + qwenReply);
WriteLine("");

// Create a conversation using the Gemma3 model, and send the same prompt to it
WriteLine("Asking Gemma3 1B Instruct...");
Conversation gemmaChat = new Conversation(LanguageModel.Gemma31BInstruct);
gemmaChat.AddMessage(prompt);
string gemmaReply = gemmaChat.GetReply();
WriteLine("Gemma3 reply: " + gemmaReply);

// Release the resources used by both conversations
qwenChat.Free();
gemmaChat.Free();