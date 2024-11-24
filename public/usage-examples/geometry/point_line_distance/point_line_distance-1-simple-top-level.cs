using SplashKitSDK;
using static SplashKitSDK.SplashKit;
// Open a new window
SplashKitSDK.Window wnd = OpenWindow("Line Game", 800, 600);

 // Define start and end points of line
Point2D pnt1 = PointAt(0, 400);
Point2D pnt2 = PointAt(800, 400);

// Create a line 
Line lne = LineFrom(pnt1, pnt2);
ClearScreen();

// Draw the line to make it visible
DrawLineOnWindow(wnd, ColorBlack(), lne);

// Draw circles to indicate start and finish 
FillCircleOnWindow(wnd, ColorGreen(), 15, 400, 3);
FillCircleOnWindow(wnd, ColorRed(), 785, 400, 3);

// Load font and draw instructions text
Font font1 = LoadFontusing SplashKitSDK;("NunitoSans", "NunitoSans.ttf");
DrawTextOnWindow(wnd, "Put your cursor on the line and move from the green to red dot without straying from the line", ColorBlack(), font1, 14, 100, 200);
RefreshScreen();
Delay(3000); // Wait 3 seconds

 // While window is open 
while (!QuitRequested())
{
    ProcessEvents();

    // Define user's mouse position 
    Point2D user = MousePosition();

    // Get distance between cursor and line 
    float distance = PointLineDistance(user, lne);

     // Print to terminal
    WriteLine(distance);
    Delay(300);

     // If distance is 3 or more 
    if (distance >= 3)
    {  
        WriteLine("Game Over");
         // Break loop 
        break;
    }
}

// Close all opened windows 
CloseAllWindows();