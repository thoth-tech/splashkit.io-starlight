using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Open a 600×600 window
OpenWindow("Circle Intersection (Top-Level OOP)", 600, 600);

// Static circle parameters (centered, radius 80)
double c1X = ScreenCenter().X, c1Y = ScreenCenter().Y, c1R = 80;

// Mouse‐circle radius
double c2R = 50;

while (!QuitRequested())
{
    ProcessEvents();

    // Update mouse circle position
    var mp = MousePosition();
    double c2X = mp.X, c2Y = mp.Y;

    // 🔍 Determines if two circles overlap by comparing the distance between their centers to the sum of their radii
    bool hit = CirclesIntersect(
        c1X, c1Y, c1R,
        c2X, c2Y, c2R
    );

    // Red background on hit, white otherwise
    ClearScreen(hit ? Color.Red : Color.White);

    // Draw both circles
    FillCircle(Color.Blue,  c1X, c1Y, c1R);
    FillCircle(Color.Green, c2X, c2Y, c2R);

    RefreshScreen();
}

CloseAllWindows();
