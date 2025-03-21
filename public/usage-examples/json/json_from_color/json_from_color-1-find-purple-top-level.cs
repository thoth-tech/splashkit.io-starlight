using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Create a color
Color clr = ColorPurple;

// Convert the color to a JSON object
Json json_obj = JsonFromColor(clr);

// Display the JSON object as a string
WriteLine("JSON from Color: " + JsonToString(json_obj));

// Free the JSON object
FreeJson(json_obj);