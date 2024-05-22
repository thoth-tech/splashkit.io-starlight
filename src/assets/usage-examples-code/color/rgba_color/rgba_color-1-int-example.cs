using static SplashKitSDK.SplashKit;  
using SplashKitSDK;  

// Create a color using integer values for red, green, blue, and alpha components
Color myColor = RGBAColor(123, 234, 56, 128);

// Print the RGBA components of the color
WriteLine("The RGBA components of the color are: ");
WriteLine("Red: " + RedOf(myColor));
WriteLine("Green: " + GreenOf(myColor));
WriteLine("Blue: " + BlueOf(myColor));
WriteLine("Alpha: " + AlphaOf(myColor));
