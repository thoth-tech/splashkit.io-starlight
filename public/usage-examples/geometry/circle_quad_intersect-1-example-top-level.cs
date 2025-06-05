using static SplashKitSDK.SplashKit;

OpenWindow("Is the Circle inside the Quad?", 800, 600);

// Define an irregular quad using direct coordinates
SplashKitSDK.Quad quad = QuadFrom(
    300, 100,   // top-left
    500, 200,   // top-right
    200, 400,   // bottom-left
    600, 500    // bottom-right
);

// Define initial state
SplashKitSDK.Circle mouseCircle = CircleAt(0, 0, 30);
SplashKitSDK.Color quadColor = SplashKitSDK.Color.Black;
string message = "";

while (!QuitRequested())
{
    ProcessEvents();
    ClearScreen(SplashKitSDK.Color.White);

    // Update the circle based on current mouse position
    mouseCircle = CircleAt(MouseX(), MouseY(), 30);

    // Change color and message based on intersection
    if (CircleQuadIntersect(mouseCircle, quad))
    {
        quadColor = SplashKitSDK.Color.Green;
        message = "Yes, it is!";
    }
    else
    {
        quadColor = SplashKitSDK.Color.Red;
        message = "No, it isn't...";
    }

    // Draw quad and circle with feedback text
    FillQuad(quadColor, quad);
    DrawText(message, SplashKitSDK.Color.Black, 330, 300);
    DrawCircle(SplashKitSDK.Color.Black, mouseCircle);

    RefreshScreen();
}

CloseAllWindows();