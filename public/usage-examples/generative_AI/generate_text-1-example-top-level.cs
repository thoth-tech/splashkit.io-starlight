using SplashKitSDK;

// Prompt sent to the AI model
string prompt = "Give me a fun fact about space.";

// Let the user know the AI response is being generated
SplashKit.WriteLine("Generating AI response...");
SplashKit.WriteLine("");

// Generate a text response from the AI
string response = SplashKit.GenerateText(prompt);

// Display the prompt and AI response
SplashKit.WriteLine("Prompt: " + prompt);
SplashKit.WriteLine("");
SplashKit.WriteLine("AI Response:");
SplashKit.WriteLine(response);
