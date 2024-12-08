using SplashKitSDK;

namespace FreeAllJson
{
    public class Program
    {
        public static void Main()
        {
            // Create multiple JSON objects
            Json json1 = SplashKit.CreateJson();
            Json json2 = SplashKit.CreateJson();

            // Add some data to the JSON objects
            SplashKit.JsonSetString(json1, "name", "Breezy");
            SplashKit.JsonSetNumber(json2, "age", 25);

            SplashKit.WriteLine("Json1: " + SplashKit.JsonToString(json1));
            SplashKit.WriteLine("Json2: " + SplashKit.JsonToString(json2));

            // Free all JSON objects
            SplashKit.WriteLine("Freeing all JSON objects...");
            SplashKit.FreeAllJson();

            // These should now display a warning of an invalid JSON object
            // Attempting to use json1 or json2 after this would be invalid
            SplashKit.WriteLine("Json1: " + SplashKit.JsonToString(json1));
            SplashKit.WriteLine("Json2: " + SplashKit.JsonToString(json2));

            SplashKit.WriteLine("All JSON objects have been freed.");
        }
    }
}