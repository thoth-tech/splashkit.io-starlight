using SplashKitSDK;

namespace JsonFromFile
{
    public class Program
    {
        public static void Main()
        {
            // Create a JSON object
            Json json_obj = SplashKit.CreateJson();
            SplashKit.JsonSetString(json_obj, "name", "Breezy");
            SplashKit.JsonSetNumber(json_obj, "age", 25);
            SplashKit.JsonSetBool(json_obj, "is_active", true);

            // Save the JSON object to the file
            SplashKit.WriteLine("Saving JSON to file...");
            SplashKit.JsonToFile(json_obj, "example.json");

            // Free the original JSON object
            SplashKit.FreeJson(json_obj);
            SplashKit.WriteLine("Original JSON object freed.");

            // Load the JSON object back from the file
            SplashKit.WriteLine("Reading JSON from file...");
            Json json_from_file_obj = SplashKit.JsonFromFile("example.json");

            // Display the JSON object read from the file
            SplashKit.WriteLine("JSON read from file:");
            SplashKit.WriteLine(SplashKit.JsonToString(json_from_file_obj));

            // Free the loaded JSON object
            SplashKit.FreeJson(json_from_file_obj);
        }
    }
}