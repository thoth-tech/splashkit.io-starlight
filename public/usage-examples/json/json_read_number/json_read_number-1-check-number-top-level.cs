using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Create a JSON object with a float number
Json json_obj = CreateJson();
JsonSetNumber(json_obj, "temperature", 36);

// Read the number value from the JSON object
float temperature = JsonReadNumber(json_obj, "temperature");

// Display the number value
WriteLine("Temperature: " + temperature.ToString());

// Free the JSON object
FreeJson(json_obj);