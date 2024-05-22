using static SplashKitSDK.SplashKit;  // Include SplashKit library for color functions
using SplashKitSDK;  // Include for Color type and related functions

// Convert a string representation of a color to a color object
Color myColor = StringToColor("#FF5733");  // Some color in hexadecimal format

// Print the RGB components of the color
WriteLine("The RGB components of the color are: ");
WriteLine("Red: " + RedOf(myColor));
WriteLine("Green: " + GreenOf(myColor));
WriteLine("Blue: " + BlueOf(myColor));
