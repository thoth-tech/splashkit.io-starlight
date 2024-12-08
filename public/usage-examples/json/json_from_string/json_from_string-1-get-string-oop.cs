using SplashKitSDK;

namespace JsonFromString
{
    public class Program
    {
        public static void Main()
        {
            // JSON string to be converted
            string json_string = "{\"name\": \"Breezy\", \"age\": 25}";

            // Create a JSON object from the string
            Json json_obj = SplashKit.JsonFromString(json_string);

            // Display the JSON object as a string
            SplashKit.WriteLine("JSON from String: " + SplashKit.JsonToString(json_obj));

            // Free the JSON object
            SplashKit.FreeJson(json_obj);
        }
    }
}