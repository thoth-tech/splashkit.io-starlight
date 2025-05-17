using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Create a JSON object
Json json_object = CreateJson();

// Add some data to the JSON object
JsonSetString(json_object, "frist_name", "Lam");
JsonSetString(json_object, "last_name", "Huynh");

// Count the keys in the JSON object
int key_count = JsonCountKeys(json_object);

// Display the count of keys
WriteLine("The JSON object has " + key_count.ToString() + " keys.");
