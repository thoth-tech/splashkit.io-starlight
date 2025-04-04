using SplashKitSDK;
using static SplashKitSDK.SplashKit;  

// Create a JSON object
Json json_obj = CreateJson();

// Set a string value
JsonSetString(json_obj, "greeting", "Hello, SplashKit!");

// Display the JSON object
WriteLine("JSON: " + JsonToString(json_obj));

// Free the JSON object
FreeJson(json_obj);