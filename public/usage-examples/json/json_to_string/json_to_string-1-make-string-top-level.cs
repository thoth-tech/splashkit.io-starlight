using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Create a JSON object
Json json_obj = CreateJson();
JsonSetString(json_obj, "name", "Breezy");
JsonSetNumber(json_obj, "age", 25);
JsonSetBool(json_obj, "is_active", true);

// Convert the JSON object to a string
string json_string = JsonToString(json_obj);

// Display the JSON string
WriteLine("JSON Object as String:");
WriteLine(json_string);

// Free the JSON object
FreeJson(json_obj);