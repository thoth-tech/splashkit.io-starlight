using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Create a JSON object
Json json_obj = CreateJson();
JsonSetString(json_obj, "name", "Breezy");
JsonSetNumber(json_obj, "age", 25);
JsonSetBool(json_obj, "is_active", true);

// Save the JSON object to the file
WriteLine("Saving JSON to file...");
JsonToFile(json_obj, "example.json");

// Free the original JSON object
FreeJson(json_obj);
WriteLine("Original JSON object freed.");

// Load the JSON object back from the file
WriteLine("Reading JSON from file...");
Json json_from_file_obj = JsonFromFile("example.json");

// Display the JSON object read from the file
WriteLine("JSON read from file:");
WriteLine(JsonToString(json_from_file_obj));

// Free the loaded JSON object
FreeJson(json_from_file_obj);