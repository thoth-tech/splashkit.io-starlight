using SplashKitSDK;

namespace JsonReadBool
{
    public class Program
    {
        public static void Main()
        {
        // Create a JSON object with a boolean value
        Json json_obj = SplashKit.CreateJson();
        SplashKit.JsonSetBool(json_obj, "is_active", true);

        // Read the boolean value from the JSON object
        bool is_active = SplashKit.JsonReadBool(json_obj, "is_active");

        // Display the boolean value
        SplashKit.WriteLine("Is Active: " + is_active.ToString());

        // Free the JSON object
        SplashKit.FreeJson(json_obj);
        }
    }
}