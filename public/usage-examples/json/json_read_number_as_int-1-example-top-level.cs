using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Create a JSON object
Json json_obj = CreateJson();
JsonSetNumber(json_obj, "grade", 10);

// Read the integer value 
int grade = JsonReadNumberAsInt(json_obj, "grade");

// Display the integer value
WriteLine("Grade: " + grade.ToString());


