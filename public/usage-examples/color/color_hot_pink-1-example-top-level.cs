using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Hot Pink Colour Showcase", 800, 600);

// Store the named colour once so every shape uses the same value.
Color hotPink = ColorHotPink();

while (!QuitRequested())
{
    ProcessEvents();

    ClearScreen(Color.DarkSlateGray);

    // Repeat the colour across different shapes to showcase the result.
    FillRectangle(hotPink, 160, 120, 480, 260);
    FillCircle(hotPink, 280, 455, 55);
    FillCircle(hotPink, 400, 455, 55);
    FillCircle(hotPink, 520, 455, 55);

    DrawText("HOT PINK COLOUR SHOWCASE", Color.White, 270, 65);
    DrawText("Created with ColorHotPink()", Color.White, 300, 535);

    RefreshScreen(60);
}

CloseAllWindows();
