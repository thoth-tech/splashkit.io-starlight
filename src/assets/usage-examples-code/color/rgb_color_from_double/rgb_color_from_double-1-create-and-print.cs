using static SplashKitSDK.SplashKit; 
using SplashKitSDK;  

// Create a color using double values for red, green, and blue components
Color myColor = RGBColor(0.482, 0.918, 0.219);

// Print the RGB components of the color
WriteLine("The RGB components of the color are: ");
WriteLine("Red: " + RedOf(myColor));
WriteLine("Green: " + GreenOf(myColor));
WriteLine("Blue: " + BlueOf(myColor));
