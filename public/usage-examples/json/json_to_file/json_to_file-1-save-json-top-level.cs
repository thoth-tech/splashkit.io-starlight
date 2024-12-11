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

            // Free the JSON object
            SplashKit.FreeJson(json_obj);
            SplashKit.WriteLine("JSON object freed.");
        }
    }
}