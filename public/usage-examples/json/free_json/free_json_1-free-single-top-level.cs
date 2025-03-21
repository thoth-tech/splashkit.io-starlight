using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Create a single JSON object
Json json = CreateJson();

// Add some data to the JSON object
JsonSetString(json, "name", "Breezy");
WriteLine("Json: " + JsonToString(json));

// Free the JSON object
WriteLine("Freeing JSON object...");
FreeJson(json);

// This should now display a warning of an invalid JSON object
// Attempting to use json after this would be invalid
WriteLine("Json: " + JsonToString(json));

WriteLine("The JSON object has been freed.");