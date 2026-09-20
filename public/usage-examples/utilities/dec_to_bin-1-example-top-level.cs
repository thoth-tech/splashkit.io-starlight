using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("LED Bit Display", 800, 300);

// The bits come back as text, one character for each LED
uint displayValue = 178;
string bits = DecToBin(displayValue);

while (!QuitRequested())
{
    ProcessEvents();

    ClearScreen(ColorWhite());

    DrawText("Number: " + displayValue, ColorBlack(), 40, 40);
    DrawText("Binary: " + bits, ColorBlack(), 40, 80);

    // A lit LED is a 1 bit and a dark LED is a 0 bit
    int ledX = 80;
    foreach (char bit in bits)
    {
        if (bit == '1')
        {
            FillCircle(ColorYellow(), ledX, 190, 32);
        }
        else
        {
            FillCircle(ColorLightGray(), ledX, 190, 32);
        }

        DrawCircle(ColorBlack(), ledX, 190, 32);
        ledX += 90;
    }

    RefreshScreen(60);
}

CloseAllWindows();
