using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Create a JSON object with an integer value
Json json_obj = CreateJson();
JsonSetNumber(json_obj, "score", 100);

// Read the integer value from the JSON object
int score = (int)JsonReadNumberAsInt(json_obj, "score");

// Display the integer value
WriteLine("Score: " + score.ToString());

// Free the JSON object
FreeJson(json_obj);