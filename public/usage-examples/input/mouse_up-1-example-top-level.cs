using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Mouse Button Lamp", 800, 600);

while (!QuitRequested())
{
    ProcessEvents();

    ClearScreen(ColorWhite());

    DrawText("Hold the left mouse button to turn the lamp red.", ColorBlack(), 20, 20);

    // The lamp stays green while the button is released and turns red for as long as it is held
    if (MouseUp(MouseButton.LeftButton))
    {
        FillCircle(ColorGreen(), 400, 330, 110);
        DrawText("Left button: up", ColorBlack(), 20, 60);
    }
    else
    {
        FillCircle(ColorRed(), 400, 330, 110);
        DrawText("Left button: down", ColorBlack(), 20, 60);
    }

    DrawCircle(ColorBlack(), 400, 330, 110);

    RefreshScreen(60);
}

CloseAllWindows();
