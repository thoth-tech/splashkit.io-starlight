using SplashKitSDK;
using static SplashKitSDK.SplashKit;

Window window = new Window("Point In Quad", 800, 600);

Point2D cursor_pos;
Color quad_clr;
string text;
Quad quad = QuadFrom(PointAt(250, 180), PointAt(500, 210), PointAt(300, 380), PointAt(480, 480));
            
while (!QuitRequested())
{
    ProcessEvents();
    cursor_pos = MousePosition();

    // The text and quad colour is updated depending on whether cursor is inside the quad
    if (SplashKit.PointInQuad(cursor_pos, quad))
    {
        quad_clr = ColorGreen();
        text = "Cursor in the quad!";
    }
    else
    {
        quad_clr = ColorRed();
        text = "Cursor not in the quad!";
    }
    
    ClearScreen();
    DrawQuad(quad_clr, quad);
    DrawText(text, quad_clr, 300, 100);
    RefreshScreen();
}
window.Close();