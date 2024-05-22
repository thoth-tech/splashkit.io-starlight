using static SplashKitSDK.SplashKit; 
using SplashKitSDK;  

// Create a color
Color myColor = RGBColor(123, 234, 56);

// Get the hue component of the color
double hue = HueOf(myColor);

// Print the hue component
WriteLine("The hue component of the color is: " + hue);
