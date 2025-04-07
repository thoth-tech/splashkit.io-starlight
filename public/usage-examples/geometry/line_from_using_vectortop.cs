using SplashKitSDK;

SplashKit.OpenWindow("Vector Field Visualization", 800, 600);

while (!SplashKit.WindowCloseRequested("Vector Field Visualization"))
{
    SplashKit.ProcessEvents();

    SplashKit.ClearScreen(Color.White);

    // Drawing lines originating from grid points
    for (int x = 50; x < 800; x += 50)
    {
        for (int y = 50; y < 600; y += 50)
        {
            // Define a vector (line) with small offsets as an example
            Line l = SplashKit.LineFrom(x, y, x + 20, y + 10);
            // Draw the line in blue
            SplashKit.DrawLine(Color.Blue, l);
        }
    }

    SplashKit.RefreshScreen();
}
