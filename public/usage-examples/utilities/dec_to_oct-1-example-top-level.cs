using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Octal Receipt Codes", 700, 360);

// Each order number is printed on its receipt as a short octal code
uint[] orderNumbers = { 8, 64, 500, 4095 };

while (!QuitRequested())
{
    ProcessEvents();

    ClearScreen(ColorWhite());

    DrawText("Order number", ColorBlack(), 60, 40);
    DrawText("Receipt code (octal)", ColorBlack(), 300, 40);
    DrawLine(ColorBlack(), 40, 70, 660, 70);

    for (int row = 0; row < orderNumbers.Length; row++)
    {
        string receiptCode = DecToOct(orderNumbers[row]);
        double rowY = 100 + row * 50;

        DrawText(orderNumbers[row].ToString(), ColorBlack(), 60, rowY);
        DrawText(receiptCode, ColorBlue(), 300, rowY);
    }

    RefreshScreen(60);
}

CloseAllWindows();
