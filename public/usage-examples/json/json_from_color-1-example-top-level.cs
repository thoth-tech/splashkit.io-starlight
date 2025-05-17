using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Create a color
Color clr = Color.Black;

// Convert the color to a JSON object
Json json_object = JsonFromColor(clr);

// Display the JSON object as a string
WriteLine("JSON from Color: " + JsonToString(json_object));