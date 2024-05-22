using static SplashKitSDK.SplashKit;  
using SplashKitSDK;

// Create a color using integer values for red, green, and blue components
Color myColor = RGBColor(123, 234, 56);

// Print the RGB components of the color
WriteLine("The RGB components of the color are: ");
WriteLine("Red: " + RedOf(myColor));
WriteLine("Green: " + GreenOf(myColor));
WriteLine("Blue: " + BlueOf(myColor));
