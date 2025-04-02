using System;
using SplashKitSDK;

public class FontExample
{
    public static void Main()
    {
        // opening a window
        Window myWindow = SplashKit.OpenWindow("Usage Example", 800, 600);
        // loading a font
        Font arialFont = SplashKit.LoadFont("Arial", "C:/Users/jangh/Desktop/SplashKitTestCpp/splashkit.io-starlight/src/fonts/arial.ttf");
        
        // creating a loop so that the window stays open
        while (!myWindow.CloseRequested)
        {
            // to keep window responsive
            SplashKit.ProcessEvents();
            // clearing the screen
            SplashKit.ClearScreen(Color.White);
            // with the loaded font, we will be drawing the text to display
            SplashKit.DrawText("Hello, This is a usage example", Color.Black, arialFont, 32, 100, 100);
            // refreshing the screen
            SplashKit.RefreshScreen(60);
        }
        // the loop ends, which means its time to exit
        // so we'll free all the fonts before before the exit
        SplashKit.FreeAllFonts();

        // closing the window 
        myWindow.Close();
    }
}
