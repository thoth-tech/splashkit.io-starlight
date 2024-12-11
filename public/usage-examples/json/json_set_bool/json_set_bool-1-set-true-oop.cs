using SplashKitSDK;

namespace JsonSetBool
{
    public class Program
    {
        public static void Main()
        {
            // Create a JSON object
            Json json_obj = SplashKit.CreateJson();

            // Set a boolean value
            SplashKit.JsonSetBool(json_obj, "is_active", true);

            // Display the JSON object
            SplashKit.WriteLine("JSON: " + SplashKit.JsonToString(json_obj));

            // Free the JSON object
            SplashKit.FreeJson(json_obj);
        }
    }
}