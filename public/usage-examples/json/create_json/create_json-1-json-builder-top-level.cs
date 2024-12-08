using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Create an empty JSON object
Json jsonObj = CreateJson();

// Add some data to the JSON object
JsonSetString(jsonObj, "name", "Breezy");
JsonSetNumber(jsonObj, "age", 25);

// Display the JSON object as a string
WriteLine("Created JSON: " + JsonToString(jsonObj));