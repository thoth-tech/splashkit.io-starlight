using SplashKitSDK;

namespace FreeJson
{
    public class Program
    {
        public static void Main()
        {
            // Create a single JSON object
            Json json = SplashKit.CreateJson();

            // Add some data to the JSON object
            SplashKit.JsonSetString(json1, "name", "Breezy");
            SplashKit.WriteLine("Json: " + SplashKit.JsonToString(json));

            // Free the JSON object
            SplashKit.WriteLine("Freeing the JSON object...");
            SplashKit.FreeJson(json);

            // These should now display a warning of an invalid JSON object
            // Attempting to use json after this would be invalid
            SplashKit.WriteLine("Json: " + SplashKit.JsonToString(json));

            SplashKit.WriteLine("The JSON object has been freed.");
        }
    }
}