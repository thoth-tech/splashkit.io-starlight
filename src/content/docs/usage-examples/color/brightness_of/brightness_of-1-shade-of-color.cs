using SplashKitSDK;

// Define a color with RGBA values
Color myColor = SplashKit.RGBAColor(100, 100, 123, 255); // A shade of color

// Get the brightness value of the color
int brightness = SplashKit.BrightnessOf(myColor);

// Print the brightness value
SplashKit.WriteLine("The brightness value of myColor is: " + brightness);

// Open a window
Window window = SplashKit.OpenWindow("Brightness Of Example", 400, 400);

// Draw a filled circle on the screen using the color from above
SplashKit.ClearScreen();
SplashKit.FillCircle(myColor, 200, 200, 100);
SplashKit.RefreshScreen();

// Keep the window open for 5 seconds
SplashKit.Delay(5000);

// Close the window
SplashKit.CloseWindow(window);
