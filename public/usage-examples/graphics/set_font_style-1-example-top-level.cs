using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Set Font Style", 800, 600);

// Different fonts can be added to the fonts folder and used below ↓
Font font = FontNamed("Century.ttf");
Rectangle rectangle = RectangleFrom(100, 200, 150, 30);

while (!QuitRequested())
{
    ProcessEvents();

    if (ReadingText() == false)
    {
        StartReadingText(rectangle);
    }

    // Function used here ↓
    if (TextInput() == "1")
    {
        SetFontStyle(font, FontStyle.BoldFont);
    }
    else if (TextInput() == "2")
    {
        SetFontStyle(font, FontStyle.ItalicFont);
    }
    else if (TextInput() == "3")
    {
        SetFontStyle(font, FontStyle.UnderlineFont);
    }
    else
    {
        SetFontStyle(font, FontStyle.NormalFont);
    }

    ClearScreen(ColorWhite());
    DrawText("Please select your desired font style (type numbers 1-3):", ColorBlack(), font, 15, 100, 60);
    DrawText("1 - Bold", ColorBlack(), font, 15, 100, 90);
    DrawText("2 - Italic", ColorBlack(), font, 15, 100, 120);
    DrawText("3 - Underline", ColorBlack(), font, 15, 100, 150);
    DrawRectangle(ColorBlack(), 100, 200, 150, 30);
    DrawText(TextInput(), ColorBlack(), 110, 210);
    RefreshScreen();
}
CloseAllWindows();