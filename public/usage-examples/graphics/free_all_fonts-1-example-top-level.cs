using SplashKitSDK;

// Open a window and load a font
Window myWindow = SplashKit.OpenWindow("Usage Example", 800, 600);
Font arialFont = SplashKit.LoadFont("Arial", "src/fonts/arial.ttf");

// Main loop to keep the window open
while (!myWindow.CloseRequested)
{
    SplashKit.ProcessEvents();
    SplashKit.ClearScreen(Color.White);
    // Display a message
    SplashKit.DrawText("Hello, This is a usage example", Color.Black, arialFont, 32, 100, 100);
    SplashKit.RefreshScreen(60);
}

// Free fonts and close the window
SplashKit.FreeAllFonts();
myWindow.Close();
