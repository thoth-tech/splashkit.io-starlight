using static SplashKitSDK.SplashKit; 
using SplashKitSDK;  

// Generate a random color
Color myColor = RandomColor();

// Print the RGB components of the color
WriteLine("The RGB components of the random color are: ");
WriteLine("Red: " + RedOf(myColor));
WriteLine("Green: " + GreenOf(myColor));
WriteLine("Blue: " + BlueOf(myColor));
