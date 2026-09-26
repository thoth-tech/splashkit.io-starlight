using SplashKitSDK;
using static SplashKitSDK.SplashKit;

string rawJson = "{\"player\":\"Avery\",\"level\":5,\"status\":\"ready\"}";

Json playerData = JsonFromString(rawJson);
string jsonText = JsonToString(playerData);

WriteLine("Original JSON string:");
WriteLine(rawJson);
WriteLine("");
WriteLine("JSON object converted back to string:");
WriteLine(jsonText);

FreeJson(playerData);