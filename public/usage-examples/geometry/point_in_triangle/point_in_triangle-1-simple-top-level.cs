using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Point In triangle", 800, 600);
ClearScreen();

// Create a triangle A
Triangle A = TriangleFrom(700, 200, 500, 1, 200, 500);

// Create a point 2d name mounse point
Point2D MousePoint;

while (!QuitRequested())
{   
    ProcessEvents();

    // Set mouse point to the position of mouse
    MousePoint = MousePosition();
    
    // When mouse inside the triangle show text "point in the triangle!" and the color of the triangle change to red
    if (PointInTriangle(MousePoint, A))
    {
        ClearScreen();
        DrawTriangle(ColorRed(), A);
        string text = "Point in the triangle!";
        DrawText(text, ColorRed(), 100, 100);
        RefreshScreen();
    }
    // When mouse do not inside the triangle show text "point not in the triangle!" and the color of the triangle change to green
    else
    {
        ClearScreen();
        DrawTriangle(ColorGreen(), A);
        string text = "Point not in the triangle!";
        DrawText(text, ColorRed(), 100, 100);
        RefreshScreen();
    }
}

RefreshScreen();
Delay(4000);
CloseAllWindows();

