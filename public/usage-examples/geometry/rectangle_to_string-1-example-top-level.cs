using SplashKitSDK;

// Declare a variable with camelCase
string exampleMessage = "this is an example of camelCase";

// Open a graphics window with a descriptive name
SplashKit.OpenWindow("Framed and Labeled", 600, 400);

// Create a rectangle
Rectangle exampleRectangle = SplashKit.RectangleFrom(100, 150, 200, 120);

// Convert the rectangle to a string
string rectangleText = SplashKit.RectangleToString(exampleRectangle);

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

    // Draw the string version of the rectangle
    SplashKit.DrawText(rectangleText, Color.Black, "Arial", 14, 20, 20);

    SplashKit.RefreshScreen();
}

SplashKit.CloseWindow("Framed and Labeled");
