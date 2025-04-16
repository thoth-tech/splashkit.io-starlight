using SplashKitSDK;
using static SplashKitSDK.SplashKit;

Window window = new Window("Get System Font", 800, 600);

Font font = null;

// The get system font function writes a font to this variable. If it is unable to find one, it won't write anything and the variable will remain blank
font = GetSystemFont();
            
while (!QuitRequested())
{
    ProcessEvents();
    if (font != null)
    {
        DrawText("System font detected!", ColorBlack(), 300, 100);

        // This line uses draw_text to give an example using this font
        DrawText("The quick brown fox jumps over the lazy dog", ColorBlack(), font, 30, 50, 150);
    }
    else
    {
        DrawText("No system font detected!", ColorBlack(), 300, 100);
    }
    RefreshScreen();
}
window.Close();