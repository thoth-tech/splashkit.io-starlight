using SplashKitSDK;

// Open a window
SplashKit.OpenWindow("Log Example", 800, 600);

SplashKit.WriteLine("Log Example");
SplashKit.WriteLine("Check the console/terminal for logged messages");
SplashKit.WriteLine("Press any key to exit");

// Log different types of messages
SplashKit.Log("INFO", "Application started successfully");
SplashKit.Log("DEBUG", "Debug information: Window opened at 800x600");
SplashKit.Log("WARNING", "This is a warning message");
SplashKit.Log("ERROR", "This is an error message");

// Log with different message types
SplashKit.Log("INFO", "User clicked the start button");
SplashKit.Log("DEBUG", "Button position: x=100, y=200");
SplashKit.Log("INFO", "Game score: 1500 points");
SplashKit.Log("WARNING", "Low memory warning: 10MB remaining");

while (!SplashKit.WindowCloseRequested("Log Example"))
{
    // Clear the screen
    SplashKit.ClearScreen(Color.White);
    
    // Display logging information
    SplashKit.DrawText("Log Example - Check Console/Terminal", Color.Black, 50, 50);
    SplashKit.DrawText("The following messages have been logged:", Color.Black, 50, 100);
    
    SplashKit.DrawText("INFO: Application started successfully", Color.Blue, 70, 150);
    SplashKit.DrawText("DEBUG: Debug information: Window opened at 800x600", Color.Green, 70, 180);
    SplashKit.DrawText("WARNING: This is a warning message", Color.Orange, 70, 210);
    SplashKit.DrawText("ERROR: This is an error message", Color.Red, 70, 240);
    SplashKit.DrawText("INFO: User clicked the start button", Color.Blue, 70, 270);
    SplashKit.DrawText("DEBUG: Button position: x=100, y=200", Color.Green, 70, 300);
    SplashKit.DrawText("INFO: Game score: 1500 points", Color.Blue, 70, 330);
    SplashKit.DrawText("WARNING: Low memory warning: 10MB remaining", Color.Orange, 70, 360);
    
    // Instructions
    SplashKit.DrawText("Look at your console/terminal to see the actual log messages", Color.Black, 50, 450);
    SplashKit.DrawText("Press any key to exit", Color.Black, 50, 500);
    
    // Refresh the screen
    SplashKit.RefreshScreen();
    
    // Process events
    SplashKit.ProcessEvents();
    
    // Small delay
    SplashKit.Delay(16);
}

// Log application exit
SplashKit.Log("INFO", "Application shutting down"); 