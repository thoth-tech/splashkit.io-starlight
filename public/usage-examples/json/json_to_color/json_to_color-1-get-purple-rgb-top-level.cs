using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Create a JSON object with a color string
Json json_obj = CreateJson();
JsonSetString(json_obj, "color", "#8040FFFF"); // Purple

// Convert the JSON object to a color
Color clr = JsonToColor(json_obj);

// Display the color components
WriteLine("Color created from JSON:");
WriteLine("Red: " + RedOf(clr));
WriteLine("Green: " + GreenOf(clr));
WriteLine("Blue: " + BlueOf(clr));
WriteLine("Alpha: " + AlphaOf(clr));

// Free the JSON object
FreeJson(json_obj);