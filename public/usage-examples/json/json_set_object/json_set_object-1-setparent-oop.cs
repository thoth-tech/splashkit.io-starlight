using SplashKitSDK;

namespace JsonSetObject
{
    public class Program
    {
        public static void Main()
        {
            // Create parent and child JSON objects
            Json parent_json = SplashKit.CreateJson();
            Json child_json = SplashKit.CreateJson();

            // Set data in the child JSON object
            SplashKit.JsonSetString(child_json, "name", "Breezy");

            // Add the child JSON to the parent JSON
            SplashKit.JsonSetObject(parent_json, "user", child_json);

            // Display the parent JSON object
            SplashKit.WriteLine("JSON: " + SplashKit.JsonToString(parent_json));

            // Free the JSON objects
            SplashKit.FreeJson(parent_json);
            SplashKit.FreeJson(child_json);
        }
    }
}