using SplashKitSDK;

namespace JsonReadNumber
{
    public class Program
    {
        public static void Main()
        {
        // Create a JSON object with a float number
        Json json_obj = SplashKit.CreateJson();
        SplashKit.JsonSetNumber(json_obj, "temperature", 36);

        // Read the number value from the JSON object
        float temperature = SplashKit.JsonReadNumber(json_obj, "temperature");

        // Display the number value
        SplashKit.WriteLine("Temperature: " + temperature.ToString());

        // Free the JSON object
        SplashKit.FreeJson(json_obj);
        }
    }
}