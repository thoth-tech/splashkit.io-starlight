using SplashKitSDK;

// opening a window 
Window myWindow = SplashKit.OpenWindow("SplashKit Example", 800, 600);
// loading a font
Font arialFont = SplashKit.LoadFont("Arial", "C:/Users/jangh/Desktop/SplashKitTestCpp/splashkit.io-starlight/src/fonts/arial.ttf");

// creating a loop so that the window stays open
while (!myWindow.CloseRequested)
{
    // to keep window responsive 
    SplashKit.ProcessEvents();
    // clearing the screen
    SplashKit.ClearScreen(Color.White);
    // with the loaded font, we will be drawing 
    SplashKit.DrawText("Hello, This is Usage example", Color.Black, arialFont, 32, 100, 100);

    // refreshing the screen
    SplashKit.RefreshScreen(60);
}

// we'll free all the fonts before exiting 
SplashKit.FreeAllFonts();

// closing the window/ exit
myWindow.Close();
