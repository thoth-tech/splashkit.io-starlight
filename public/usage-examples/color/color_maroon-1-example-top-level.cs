using SplashKitSDK;
using static SplashKitSDK.SplashKit;

SplashKit.OpenWindow("Color Maroon", 800, 600);

while (!SplashKit.QuitRequested())
{
    SplashKit.ProcessEvents();
    SplashKit.ClearScreen(Color.White);

    // Muted supporting colors
    Color mutedGreen = SplashKit.RGBColor(90, 110, 80);
    Color cream = SplashKit.RGBColor(210, 190, 150);

    // Draw the stem
    SplashKit.FillRectangle(mutedGreen, 395, 330, 10, 180);

    // Draw the leaves
    SplashKit.FillCircle(mutedGreen, 365, 420, 30);
    SplashKit.FillCircle(mutedGreen, 435, 450, 30);

    // Draw the maroon flower petals
    SplashKit.FillCircle(Color.Maroon, 400, 220, 55);
    SplashKit.FillCircle(Color.Maroon, 330, 270, 55);
    SplashKit.FillCircle(Color.Maroon, 470, 270, 55);
    SplashKit.FillCircle(Color.Maroon, 355, 345, 55);
    SplashKit.FillCircle(Color.Maroon, 445, 345, 55);

    // Draw the muted flower centre
    SplashKit.FillCircle(cream, 400, 290, 55);

    SplashKit.RefreshScreen();
}

SplashKit.CloseAllWindows();