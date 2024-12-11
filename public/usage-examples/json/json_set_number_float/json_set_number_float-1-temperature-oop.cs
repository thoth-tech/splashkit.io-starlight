using SplashKitSDK;

namespace JsonSetNumberFloat
{
    public class Program
    {
        public static void Main()
        {
            // Create a JSON object
            Json json_obj = SplashKit.CreateJson();

            // Set a float value
            SplashKit.JsonSetNumber(json_obj, "temperature", 36.6f);

            // Display the JSON object
            SplashKit.WriteLine("JSON: " + SplashKit.JsonToString(json_obj));

            // Free the JSON object
            SplashKit.FreeJson(json_obj);
        }
    }
}