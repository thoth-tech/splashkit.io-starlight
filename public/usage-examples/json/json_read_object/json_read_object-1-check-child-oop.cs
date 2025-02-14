using SplashKitSDK;

namespace JsonReadObject
{
    public class Program
    {
        public static void Main()
        {
            // Create a parent JSON object with a nested JSON object
            Json parent_json = SplashKit.CreateJson();
            Json child_json = SplashKit.CreateJson();
            SplashKit.JsonSetString(child_json, "name", "Breezy");
            SplashKit.JsonSetObject(parent_json, "user", child_json);

            // Read the nested JSON object
            Json user_json = SplashKit.JsonReadObject(parent_json, "user");

            // Display a value from the nested JSON object
            SplashKit.WriteLine("User Name: " + SplashKit.JsonReadString(user_json, "name"));

            // Free the JSON objects
            SplashKit.FreeJson(parent_json);
            SplashKit.FreeJson(child_json);
        }
    }
}