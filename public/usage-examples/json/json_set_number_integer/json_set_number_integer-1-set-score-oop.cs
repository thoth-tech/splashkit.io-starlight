using SplashKitSDK;

namespace SetNumberInt
{
    public class Program
    {
        public static void Main()
        {
            // Create a JSON object
            Json json_obj = SplashKit.CreateJson();

            // Set an integer value
            SplashKit.JsonSetNumber(json_obj, "score", 100);

            // Display the JSON object
            SplashKit.WriteLine("JSON: " + SplashKit.JsonToString(json_obj));

            // Free the JSON object
            SplashKit.FreeJson(json_obj);
        }
    }
}