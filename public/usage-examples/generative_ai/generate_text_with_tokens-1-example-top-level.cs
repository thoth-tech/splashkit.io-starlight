using SplashKitSDK;
using static SplashKitSDK.SplashKit;

string prompt = "Once upon a time, there was a robot who";

WriteLine("Prompt: " + prompt);

// Generate a continuation of the story, limited to 50 tokens
string story = GenerateText(prompt, 50);

WriteLine("Generated story: " + story);