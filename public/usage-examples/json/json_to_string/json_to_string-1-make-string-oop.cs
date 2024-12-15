using SplashKitSDK;

namespace JsonToString
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

            // Convert the JSON object to a string
            string json_string = SplashKit.JsonToString(json_obj);

            // Display the JSON string
            SplashKit.WriteLine("JSON Object as String:");
            SplashKit.WriteLine(json_string);

            // Free the JSON object
            SplashKit.FreeJson(json_obj);
        }
    }
}