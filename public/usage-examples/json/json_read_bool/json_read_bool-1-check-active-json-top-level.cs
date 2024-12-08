using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Create a JSON object with a boolean value
Json json_obj = CreateJson();
JsonSetBool(json_obj, "is_active", true);

// Read the boolean value from the JSON object
bool is_active = JsonReadBool(json_obj, "is_active");

// Display the boolean value
WriteLine("Is Active: " + is_active.ToString());

// Free the JSON object
FreeJson(json_obj);