using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Open a 600×600 window
OpenWindow("Circle Intersection (Values)", 600, 600);

// Static circle parameters
double c1_x = ScreenCenter().X;
double c1_y = ScreenCenter().Y;
double c1_r = 80;

while (!QuitRequested())
{
    ProcessEvents();

    // Mouse‐controlled circle parameters
    var mp = MousePosition();
    double c2_x = mp.X;
    double c2_y = mp.Y;
    double c2_r = 50;

    // Determines if two circles overlap by comparing the distance between their centers to the sum of their radii
    bool hit = CirclesIntersect(c1_x, c1_y, c1_r,
                                c2_x, c2_y, c2_r);

    // Red background on hit, white otherwise
    ClearScreen(hit ? Color.Red() : Color.White());

    // Draw both circles by values
    FillCircle(Color.Blue(),  c1_x, c1_y, c1_r);
    FillCircle(Color.Green(), c2_x, c2_y, c2_r);

    RefreshScreen();
    Delay(10);
}

CloseAllWindows();
