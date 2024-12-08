using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// JSON string to be converted
string json_string = "{\"name\": \"Breezy\", \"age\": 25}";

// Create a JSON object from the string
Json json_obj = JsonFromString(json_string);

// Display the JSON object as a string
WriteLine("JSON from String: " + JsonToString(json_obj));

// Free the JSON object
FreeJson(json_obj);