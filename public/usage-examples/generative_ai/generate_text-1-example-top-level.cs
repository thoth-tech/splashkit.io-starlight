using static SplashKitSDK.SplashKit;

// Define a prompt to send to the AI
// Note: Requires a local AI model to be set up via SplashKit
string prompt = "What is the capital of France?";
WriteLine("Prompt: " + prompt);

// Generate a text response from the AI
string response = GenerateText(prompt);
WriteLine("Response: " + response);
