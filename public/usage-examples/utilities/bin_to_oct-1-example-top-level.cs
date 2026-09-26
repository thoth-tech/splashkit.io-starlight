using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Bit Groups to Octal", 800, 360);

string bits = "101110011";

while (!QuitRequested())
{
    ProcessEvents();

    ClearScreen(ColorWhite());

    string octalCode = "";

    for (int group = 0; group < 3; group++)
    {
        // Every group of three bits is exactly one octal digit
        string groupBits = bits.Substring(group * 3, 3);
        string octalDigit = BinToOct(groupBits);
        octalCode += octalDigit;

        double groupX = 80 + group * 240;
        FillRectangle(ColorLightBlue(), groupX, 120, 160, 150);
        DrawRectangle(ColorBlack(), groupX, 120, 160, 150);
        DrawText(groupBits, ColorBlack(), groupX + 68, 150);
        DrawText(octalDigit, ColorBlue(), groupX + 76, 220);
    }

    DrawText("Binary: " + bits, ColorBlack(), 40, 40);
    DrawText("Octal: " + octalCode, ColorBlack(), 40, 75);

    RefreshScreen(60);
}

CloseAllWindows();
