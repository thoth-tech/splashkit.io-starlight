using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Create a JSON object
Json json_obj = CreateJson();

// Set an integer value
JsonSetNumber(json_obj, "score", 100);

// Display the JSON object
WriteLine("JSON: " + JsonToString(json_obj));

// Free the JSON object
FreeJson(json_obj);