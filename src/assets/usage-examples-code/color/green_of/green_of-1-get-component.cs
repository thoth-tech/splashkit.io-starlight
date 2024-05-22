using static SplashKitSDK.SplashKit;
using SplashKitSDK;  

// Create a color
Color myColor = Color.RGBColor(123, 234, 56);

// Get the green component of the color
int green = GreenOf(myColor);

// Print the green component
WriteLine("The green component of the color is: " + green);
