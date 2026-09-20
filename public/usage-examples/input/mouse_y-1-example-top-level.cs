using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Mouse Height Gauge", 800, 600);

while (!QuitRequested())
{
    ProcessEvents();

    // Read the height once so the line, the bar and the text always agree
    float pointerHeight = MouseY();

    ClearScreen(ColorWhite());

    // The bar grows from the bottom of the window up to the pointer
    FillRectangle(ColorBlue(), 340, pointerHeight, 120, 600 - pointerHeight);
    DrawLine(ColorRed(), 0, pointerHeight, 800, pointerHeight);

    DrawText("Move the mouse up and down to change the gauge.", ColorBlack(), 20, 20);
    DrawText("Mouse Y: " + (int)pointerHeight, ColorBlack(), 20, 60);

    RefreshScreen(60);
}

CloseAllWindows();
