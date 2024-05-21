using SplashKitSDK;

// Define the color Cyan
Color myColor = SplashKit.ColorCyan();

// Open a window
Window window = SplashKit.OpenWindow("Cyan Example", 400, 400);

// Draw a filled circle on the screen using the color from above
SplashKit.ClearScreen();
SplashKit.FillCircle(myColor, 200, 200, 100);
SplashKit.RefreshScreen();

// Keep the window open for 5 seconds
SplashKit.Delay(5000);

// Close the window
SplashKit.CloseWindow(window);
