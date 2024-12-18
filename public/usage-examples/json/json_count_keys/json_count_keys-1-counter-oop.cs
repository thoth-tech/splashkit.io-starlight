using SplashKitSDK;

namespace CountKeys
{
    public class Program
    {
        public static void Main()
        {
        // Create a JSON object
        Json json_obj = SplashKit.CreateJson();

        // Add some data to the JSON object
        SplashKit.JsonSetString(json_obj, "name", "Breezy");
        SplashKit.JsonSetNumber(json_obj, "age", 25);
        SplashKit.JsonSetString(json_obj, "hobby", "Coding");

        // Count the keys in the JSON object
        int key_count = SplashKit.JsonCountKeys(json_obj);

        // Display the count of keys
        SplashKit.WriteLine("The JSON object has " + key_count.ToString() + " keys.");

        // Free the JSON object
        SplashKit.FreeJson(json_obj);
        }
    }
}