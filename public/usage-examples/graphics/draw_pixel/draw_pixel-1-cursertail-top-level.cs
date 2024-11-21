using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// declare variables
const int trail_length = 50;
Point2D mousePoint;
Point2D[] mouse_history = new Point2D[trail_length];
Color[] Colorlist = {ColorBlue(),ColorRed(),ColorGreen(),ColorYellow(),ColorPink()};


OpenWindow("draw pixel", 600, 600);


while(!QuitRequested())
{

    mousePoint = MousePosition();
    ClearScreen(ColorBlack());
    // set mouse position history 
    for(int i = 0; i < trail_length - 1; i++)
    {
        // shuffle forward
        mouse_history[i] = mouse_history[i + 1];
    }
    mouse_history[trail_length - 1] = mousePoint;
    // draw mouse trail
    for(int i = 0; i < trail_length; i++)
    {
        DrawPixel(Colorlist[i%5],mouse_history[i]);
    }
    ProcessEvents();
    RefreshScreen(60);
}

