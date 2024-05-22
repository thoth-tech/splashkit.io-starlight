using static SplashKitSDK.SplashKit;  
using SplashKitSDK;  

// Generate a random RGB color with alpha 128
Color myColor = RandomRGBColor(128);

// Print the RGBA components of the color
WriteLine("The RGBA components of the random color are: ");
WriteLine("Red: " + RedOf(myColor));
WriteLine("Green: " + GreenOf(myColor));
WriteLine("Blue: " + BlueOf(myColor));
WriteLine("Alpha: " + AlphaOf(myColor));
