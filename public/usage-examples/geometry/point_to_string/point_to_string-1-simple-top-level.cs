using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Variable Declaration
string ClickMessage = "Mouse clicked at ";
string MousePositionText = "";

// Open Window
OpenWindow("Mouse Clicked Location", 600, 600);
ClearScreen(ColorGhostWhite());

while (!QuitRequested())
{
    // Check for mouse click
    if (MouseClicked(MouseButton.LeftButton))
    { 
        MousePositionText = PointToString(MousePosition());
        ClearScreen(ColorGhostWhite());
    }

    // Print mouse position to screen
    DrawText(ClickMessage + MousePositionText, ColorBlack(), 100, 300);
    ProcessEvents();
    RefreshScreen();
}

CloseAllWindows();
