using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Draws red rectangles on one window and blue rectangles on another window.
// Each window is cleared to white before drawing.
// The rectangles are spaced evenly and demonstrate drawing on multiple windows.

// Open two windows side by side
Window redWindow = new Window("Red Rectangles", 400, 300);
Window blueWindow = new Window("Blue Rectangles", 400, 300);
MoveWindowTo(blueWindow, WindowX(redWindow) + WindowWidth(redWindow), WindowY(redWindow));

// Clear both windows
ClearWindow(redWindow, Color.White);
ClearWindow(blueWindow, Color.White);

// Draw red rectangles on the first window
for (int i = 0; i < 5; i++)
{
    FillRectangleOnWindow(redWindow, Color.Red, 30 + i * 60, 80, 40, 100);
}

// Draw blue rectangles on the second window
for (int i = 0; i < 5; i++)
{
    FillRectangleOnWindow(blueWindow, Color.Blue, 30 + i * 60, 80, 40, 100);
}

RefreshWindow(redWindow);
RefreshWindow(blueWindow);

Delay(4000);

redWindow.Close();
blueWindow.Close();
