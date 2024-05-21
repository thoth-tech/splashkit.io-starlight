using SplashKitSDK;

// Define a color with RGBA values
Color myColor = SplashKit.RGBAColor(255, 0, 0, 128); // Red with 50% transparency

// Get the alpha value of the color
int alphaValue = SplashKit.AlphaOf(myColor);

// Print the alpha value
SplashKit.WriteLine("The alpha value of myColor is: " + alphaValue);

// Open a window
Window window = SplashKit.OpenWindow("AlphaOf Example", 400, 400);

// Draw a filled circle on the screen using the color from above
SplashKit.ClearScreen();
SplashKit.FillCircle(myColor, 200, 200, 100);
SplashKit.RefreshScreen();

// Keep the window open for 5 seconds
SplashKit.Delay(5000);

// Close the window
SplashKit.CloseWindow(window);
