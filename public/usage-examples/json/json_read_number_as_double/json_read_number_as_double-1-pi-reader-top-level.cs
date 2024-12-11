using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Create a JSON object with a double number
Json json_obj = CreateJson();
JsonSetNumber(json_obj, "pi", 3.14159);

// Read the double value from the JSON object
double pi = JsonReadNumberAsDouble(json_obj, "pi");

// Display the double value
WriteLine("Pi: " + pi.ToString());

// Free the JSON object
FreeJson(json_obj);