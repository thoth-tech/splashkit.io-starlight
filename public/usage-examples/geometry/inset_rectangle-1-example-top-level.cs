using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Inset Rectangle Example", 400, 300);

// The fixed outer rectangle
Rectangle outerRect = RectangleFrom(50, 50, 300, 200);

double insetAmount = 0;

while (!QuitRequested())
{
    ProcessEvents();

    ClearScreen(Color.White);

    // Increase or decrease the inset amount with the arrow keys
    if (KeyDown(KeyCode.UpKey) && insetAmount < 95)
    {
        insetAmount += 1;
    }
    if (KeyDown(KeyCode.DownKey) && insetAmount > 0)
    {
        insetAmount -= 1;
    }

    // Draw the outer rectangle
    DrawRectangle(Color.Black, outerRect);

    // Get and draw the inset rectangle
    Rectangle innerRect = InsetRectangle(outerRect, (float)insetAmount);
    FillRectangle(Color.Red, innerRect);

    // Display the current inset amount, fixed to the screen
    DrawText("Inset amount: " + ToString((int)insetAmount), Color.Black, 10, 10, OptionToScreen());

    RefreshScreen(60);
}

CloseAllWindows();