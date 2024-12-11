using SplashKitSDK;

namespace JsonSetString
{
    public class Program
    {
        public static void Main()
        {
            // Create a JSON object
            Json json_obj = SplashKit.CreateJson();

            // Set a string value
            SplashKit.JsonSetString(json_obj, "greeting", "Hello, SplashKit!");

            // Display the JSON object
            SplashKit.WriteLine("JSON: " + SplashKit.JsonToString(json_obj));

            // Free the JSON object
            SplashKit.FreeJson(json_obj);
        }
    }
}