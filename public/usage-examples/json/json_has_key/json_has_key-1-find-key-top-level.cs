using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Create a JSON object
Json json_obj = CreateJson();
JsonSetString(json_obj, "name", "Breezy");

// Check if the JSON object contains specific keys
string key1 = "name";
string key2 = "age";

if (JsonHasKey(json_obj, key1))
{
    WriteLine("Key '" + key1 + "' exists in the JSON object.");
}
else
{
    WriteLine("Key '" + key1 + "' does not exist in the JSON object.");
}

if (JsonHasKey(json_obj, key2))
{
    WriteLine("Key '" + key2 + "' exists in the JSON object.");
}
else
{
    WriteLine("Key '" + key2 + "' does not exist in the JSON object.");
}

// Free the JSON object
FreeJson(json_obj);