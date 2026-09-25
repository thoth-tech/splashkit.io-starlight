using SplashKitSDK;
using static SplashKitSDK.SplashKit;

Window displayWindow = OpenWindow("Current Window Example", 800, 600);

while (!QuitRequested())
{
    ProcessEvents();

    displayWindow = CurrentWindow();

    int width = WindowWidth(displayWindow);
    int height = WindowHeight(displayWindow);
    string caption = WindowCaption(displayWindow);
    string currentStatus = IsCurrentWindow(displayWindow).ToString();

    ClearWindow(displayWindow, ColorWhite());

    DrawText("Using current_window()", ColorBlack(), 20, 20);
    DrawText("Caption: " + caption, ColorBlack(), 20, 60);
    DrawText("Window Width: " + width, ColorBlack(), 20, 100);
    DrawText("Window Height: " + height, ColorBlack(), 20, 140);
    DrawText("Is Current Window: " + currentStatus, ColorBlack(), 20, 180);

    FillRectangle(ColorBlue(), 20, 230, width - 40, 80);
    DrawText("This rectangle is drawn in the current window.", ColorWhite(), 40, 260);

    RefreshWindow(displayWindow, 60U);
}

CloseWindow(displayWindow);