using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Create the circle and window used to demonstrate the distant point
Circle demoCircle = CircleAt(400, 300, 120);
OpenWindow("Opposite Point to Mouse on Circle", 800, 600);

while (!QuitRequested())
{
    ProcessEvents();

    // Use the mouse position as the point being tested
    Point2D testPoint = MousePosition();

    // Find the point on the circle furthest from the mouse
    Point2D distantPoint = DistantPointOnCircle(testPoint, demoCircle);

    ClearScreen(ColorWhite());

    // Draw the circle and helper lines to show the relationship clearly
    DrawCircle(ColorBlack(), demoCircle);
    DrawLine(ColorGray(), CenterPoint(demoCircle), testPoint);
    DrawLine(ColorGreen(), CenterPoint(demoCircle), distantPoint);

    // Highlight the mouse point and the distant point
    FillCircle(ColorRed(), testPoint.X, testPoint.Y, 6);
    FillCircle(ColorGreen(), distantPoint.X, distantPoint.Y, 8);
    FillCircle(ColorBlue(), CenterPoint(demoCircle).X, CenterPoint(demoCircle).Y, 5);

    // Display instructions and labels on the window
    DrawText("Move the mouse to change the test point", ColorBlack(), 20, 20);
    DrawText("Red = test point", ColorRed(), 20, 50);
    DrawText("Green = distant point on circle", ColorGreen(), 20, 80);
    DrawText("Blue = circle center", ColorBlue(), 20, 110);

    RefreshScreen(60);
}