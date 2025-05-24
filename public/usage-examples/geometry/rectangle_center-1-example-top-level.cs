using SplashKitSDK;

// Declare a variable with camelCase
string exampleMessage = "this is an example of camelCase";

SplashKit.OpenWindow("Spotlight on Center", 600, 400);

Rectangle exampleRectangle = SplashKit.RectangleFrom(100, 100, 200, 150);
Point2D centerPoint = SplashKit.RectangleCenter(exampleRectangle);

while (!SplashKit.QuitRequested())
{
    SplashKit.ProcessEvents();
    SplashKit.ClearScreen(Color.White);

    // Draw the rectangle
    SplashKit.DrawRectangle(
        Color.Blue,
        exampleRectangle.X,
        exampleRectangle.Y,
        exampleRectangle.Width,
        exampleRectangle.Height
    );

    // Draw the center point
    SplashKit.FillCircle(Color.Red, centerPoint, 5);

    // Draw label near the center
    SplashKit.DrawText("Center", Color.Black, "Arial", 12, centerPoint.X + 8, centerPoint.Y - 6);

    SplashKit.RefreshScreen();
}

SplashKit.CloseWindow("Spotlight on Center");
