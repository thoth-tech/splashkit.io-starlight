using SplashKitSDK;

namespace JsonReadString
{
    public class Program
    {
        public static void Main()
        {
            // Create a JSON object with a string value
            Json json_obj = SplashKit.CreateJson();
            SplashKit.JsonSetString(json_obj, "greeting", "Hello, SplashKit!");
            SplashKit.JsonSetString(json_obj, "name", "SplashKit");

            // Read the string value from the JSON object
            string greeting = SplashKit.JsonReadString(json_obj, "greeting");

            // Display the string value
            SplashKit.WriteLine("Greeting: " + greeting);

            // Free the JSON object
            SplashKit.FreeJson(json_obj);
        }
    }
}