using SplashKitSDK;

Window window = new Window("House Drawing with Clipping", 800, 600);

// Define the clipping rectangle
Rectangle clipRect = SplashKit.RectangleFrom(250, 200, 300, 300);
SplashKit.SetClip(clipRect);

// Clear screen inside the clipping region
SplashKit.ClearScreen(Color.DarkOrange);

// House body
SplashKit.FillRectangle(Color.Beige, 300, 250, 200, 200);

// Roof
SplashKit.DrawLine(Color.Brown, 300, 250, 400, 150);
SplashKit.DrawLine(Color.Brown, 400, 150, 500, 250);
SplashKit.DrawLine(Color.Brown, 300, 250, 500, 250);

// Door
SplashKit.FillRectangle(Color.DarkRed, 375, 370, 50, 80);

// Windows
SplashKit.FillRectangle(Color.LightBlue, 320, 270, 40, 40);
SplashKit.FillRectangle(Color.LightBlue, 440, 270, 40, 40);

// Clipping boundary
SplashKit.DrawRectangle(Color.Black, clipRect);

SplashKit.RefreshScreen();
SplashKit.Delay(5000);
