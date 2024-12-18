using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Create a JSON object
Json json_obj = CreateJson();

// Add some data to the JSON object
JsonSetString(json_obj, "name", "Breezy");
JsonSetNumber(json_obj, "age", 25);
JsonSetString(json_obj, "hobby", "Coding");

// Count the keys in the JSON object
int key_count = JsonCountKeys(json_obj);

// Display the count of keys
WriteLine("The JSON object has " + key_count.ToString() + " keys.");

// Free the JSON object
FreeJson(json_obj);