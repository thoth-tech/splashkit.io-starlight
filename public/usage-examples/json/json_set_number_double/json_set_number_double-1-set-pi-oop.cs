using SplashKitSDK;

namespace JsonSetNumberDouble
{
    public class Program
    {
        public static void Main()
        {
            // Create a JSON object
            Json json_obj = SplashKit.CreateJson();

            // Set a double value
            SplashKit.JsonSetNumber(json_obj, "pi", 3.14159);

            // Display the JSON object
            SplashKit.WriteLine("JSON: " + SplashKit.JsonToString(json_obj));

            // Free the JSON object
            SplashKit.FreeJson(json_obj);
        }
    }
}