using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Point In Circle", 800, 600);
ClearScreen();

// Create a circle A
Circle A = CircleAt(400, 300, 100);

// Create a point 2d name mounse point
Point2D MousePoint;

while (!QuitRequested())
{   
    ProcessEvents();

    // Set mouse point to the position of mouse
    MousePoint = MousePosition();
    
    // When mouse inside the circle show text "point in the circle!" and the color of the circle change to red
    if (PointInCircle(MousePoint, A))
    {
        ClearScreen();
        DrawCircle(ColorRed(), A);
        string text = "Point in the Circle!";
        DrawText(text, ColorRed(), 100, 100);
        RefreshScreen();
    }
    // When mouse do not inside the circle show text "point not in the circle!" and the color of the circle change to green
    else
    {
        ClearScreen();
        DrawCircle(ColorGreen(), A);
        string text = "Point not in the Circle!";
        DrawText(text, ColorRed(), 100, 100);
        RefreshScreen();
    }
}

RefreshScreen();
Delay(4000);
CloseAllWindows();