using SplashKitSDK;

using static SplashKitSDK.SplashKit;

// Create a parent JSON object with a nested JSON object
Json parent_json = CreateJson();
Json child_json = CreateJson();
JsonSetString(child_json, "name", "Breezy");
JsonSetObject(parent_json, "user", child_json);

// Read the nested JSON object
Json user_json = JsonReadObject(parent_json, "user");

// Display a value from the nested JSON object
WriteLine("User Name: " + JsonReadString(user_json, "name"));

// Free the JSON objects
FreeJson(parent_json);
FreeJson(child_json);