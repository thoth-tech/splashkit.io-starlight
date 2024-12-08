using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Create a JSON object
Json json_obj = CreateJson();

// Set a float value
JsonSetNumber(json_obj, "temperature", 36.6f);

// Display the JSON object
WriteLine("JSON: " + JsonToString(json_obj));

// Free the JSON object
FreeJson(json_obj);