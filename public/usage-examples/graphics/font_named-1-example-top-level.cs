using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Font Named", 800, 600);

Font font;
Rectangle rectangle = RectangleFrom(100, 200, 150, 30);
            
while (!QuitRequested())
{
    ProcessEvents();
                
    if (ReadingText() == false)
    {
        StartReadingText(rectangle);
    }

    // User's string input is converted to a font variable via the font_named function
    // In this example, the .tff extension is automatically applied to the string for better usability
    // Alagard.ttf, Century.ttf and RobotoSlab.ttf as part of the program resources
    font = FontNamed(TextInput() + ".ttf");

    ClearScreen(ColorWhite());
    DrawText("Please input the name of the font you would like to use:", ColorBlack(), font, 15, 100, 60);
    DrawText("- Alagard", ColorBlack(), font, 15, 100, 90);
    DrawText("- Century", ColorBlack(), font, 15, 100, 120);
    DrawText("- RobotoSlab", ColorBlack(), font, 15, 100, 150);
    DrawRectangle(ColorBlack(), 100, 200, 150, 30);
    DrawText(TextInput(), ColorBlack(), font, 15, 105, 205);
    RefreshScreen();
}
CloseAllWindows();