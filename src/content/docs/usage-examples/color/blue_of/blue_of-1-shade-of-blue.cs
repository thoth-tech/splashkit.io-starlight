using SplashKitSDK;

// Define a color with RGBA values
Color myColor = SplashKit.RGBAColor(100, 100, 200, 255); // A shade of blue

// Get the blue value of the color
int blue = SplashKit.BlueOf(myColor);

// Print the blue value
SplashKit.WriteLine("The blue value of myColor is: " + blue);

// Open a window
Window window = SplashKit.OpenWindow("Blue Of Example", 400, 400);

// Draw a filled circle on the screen using the color from above
SplashKit.ClearScreen();
SplashKit.FillCircle(myColor, 200, 200, 100);
SplashKit.RefreshScreen();

// Keep the window open for 5 seconds
SplashKit.Delay(5000);

// Close the window
SplashKit.CloseWindow(window);
