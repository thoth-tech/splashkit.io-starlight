using static SplashKitSDK.SplashKit; 
using SplashKitSDK;  

// Create a color
Color myColor = RGBColor(123, 234, 56);

// Get the saturation component of the color
double saturation = SaturationOf(myColor);

// Print the saturation component
WriteLine("The saturation component of the color is: " + saturation);
