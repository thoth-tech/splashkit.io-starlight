using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Create a JSON object with a string value
Json json_obj = CreateJson();
JsonSetString(json_obj, "greeting", "Hello, SplashKit!");
JsonSetString(json_obj, "name", "SplashKit");

// Read the string value from the JSON object
string greeting = JsonReadString(json_obj, "greeting");

// Display the string value
WriteLine("Greeting: " + greeting);

// Free the JSON object
FreeJson(json_obj);