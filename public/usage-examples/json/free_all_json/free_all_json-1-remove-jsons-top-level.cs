using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Create multiple JSON objects
Json json1 = CreateJson();
Json json2 = CreateJson();

// Add some data to the JSON objects
JsonSetString(json1, "name", "Breezy");
JsonSetNumber(json2, "age", 25);

WriteLine("Json1: " + JsonToString(json1));
WriteLine("Json2: " + JsonToString(json2));

// Free all JSON objects
WriteLine("Freeing all JSON objects...");
FreeAllJson();

// These should now display a warning of an invalid JSON object
// Attempting to use json1 or json2 after this would be invalid
WriteLine("Json1: " + JsonToString(json1));
WriteLine("Json2: " + JsonToString(json2));

WriteLine("All JSON objects have been freed.");