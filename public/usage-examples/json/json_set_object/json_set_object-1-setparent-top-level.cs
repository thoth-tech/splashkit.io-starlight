using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Create parent and child JSON objects
Json parent_json = CreateJson();
Json child_json = CreateJson();

// Set data in the child JSON object
JsonSetString(child_json, "name", "Breezy");

// Add the child JSON to the parent JSON
JsonSetObject(parent_json, "user", child_json);

// Display the parent JSON object
WriteLine("JSON: " + JsonToString(parent_json));

// Free the JSON objects
FreeJson(parent_json);
FreeJson(child_json);