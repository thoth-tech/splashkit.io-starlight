using SplashKitSDK;
using static SplashKitSDK.SplashKit;


//Variable Declerations
Point2D mouse_point;
Rectangle boundary = RectangleFrom(150,150,300,100);


OpenWindow("point in Rectangle", 600, 600);


while(!QuitRequested())
{
    ProcessEvents();
    // get mouse position and draw boundary to screen
    mouse_point = MousePosition();
    ClearScreen(ColorGreen());
    FillRectangle(ColorWhite(), boundary);

    // Check if mouse is in the boundary
    if(!PointInRectangle(mouse_point,boundary))
    {
        //flash screen red and blue if mouse has escaped boundary
        ClearScreen(ColorDarkRed());
        FillRectangle(ColorWhite(), boundary);
        DrawText("JAILBREAK",ColorBlack(),250.0,400.0);
        RefreshScreen(2);
        ClearScreen(ColorRoyalBlue());
        FillRectangle(ColorWhite(), boundary);
        RefreshScreen(2);
    }
    RefreshScreen();
}



