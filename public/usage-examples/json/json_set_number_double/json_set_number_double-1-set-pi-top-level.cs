using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Create a JSON object
Json json_obj = CreateJson();

// Set a double value
JsonSetNumber(json_obj, "pi", 3.14159);

// Display the JSON object
WriteLine("JSON: " + JsonToString(json_obj));

// Free the JSON object
FreeJson(json_obj);