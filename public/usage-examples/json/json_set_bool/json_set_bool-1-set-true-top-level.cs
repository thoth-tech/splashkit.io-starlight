using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Create a JSON object
Json json_obj = CreateJson();

// Set a boolean value
JsonSetBool(json_obj, "is_active", true);

// Display the JSON object
WriteLine("JSON: " + JsonToString(json_obj));

// Free the JSON object
FreeJson(json_obj);