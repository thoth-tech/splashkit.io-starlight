using static SplashKitSDK.SplashKit;  
using SplashKitSDK;  

// Create a color using HSB values
Color myColor = HSBColor(180.0, 0.5, 0.75);

// Print the RGB components of the color
WriteLine("The RGB components of the color are: ");
WriteLine("Red: " + RedOf(myColor));
WriteLine("Green: " + GreenOf(myColor));
WriteLine("Blue: " + BlueOf(myColor));
