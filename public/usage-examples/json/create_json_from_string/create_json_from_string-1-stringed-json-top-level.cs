using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// JSON string to convert to a JSON object
string jsonString = "{\"name\": \"Breezy\", \"age\": 25}";

// Create a JSON object from the string
Json jsonObj = CreateJson(jsonString);

// Read and display values from the JSON object
WriteLine("Name: " + JsonReadString(jsonObj, "name"));
WriteLine("Age: " + JsonReadNumber(jsonObj, "age").ToString());