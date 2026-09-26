using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Octal Value Bars", 800, 360);

string[] octalValues = { "7", "17", "377", "777" };

while (!QuitRequested())
{
    ProcessEvents();

    ClearScreen(ColorWhite());

    DrawText("Each bar is as long as the decimal value of its octal number.", ColorBlack(), 40, 30);

    for (int row = 0; row < octalValues.Length; row++)
    {
        // The result is a number, so it is turned back into text to draw it
        uint decimalValue = OctToDec(octalValues[row]);
        double rowY = 90 + row * 60;

        DrawText("Octal " + octalValues[row], ColorBlack(), 40, rowY + 8);
        FillRectangle(ColorBlue(), 200, rowY, decimalValue, 30);
        DrawText(decimalValue.ToString(), ColorBlack(), 210 + decimalValue, rowY + 8);
    }

    RefreshScreen(60);
}

CloseAllWindows();
