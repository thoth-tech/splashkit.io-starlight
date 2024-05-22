using static SplashKitSDK.SplashKit; 
using SplashKitSDK;  

// Create a color using double values for red, green, blue, and alpha components
Color myColor = RGBAColor(0.482, 0.918, 0.219, 0.5);

// Print the RGBA components of the color
WriteLine("The RGBA components of the color are: ");
WriteLine("Red: " + RedOf(myColor));
WriteLine("Green: " + GreenOf(myColor));
WriteLine("Blue: " + BlueOf(myColor));
WriteLine("Alpha: " + AlphaOf(myColor));
