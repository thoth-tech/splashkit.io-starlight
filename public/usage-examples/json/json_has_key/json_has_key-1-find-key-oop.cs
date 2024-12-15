using SplashKitSDK;

namespace JsonHasKey
{
    public class Program
    {
        public static void Main()
        {
            // Create a JSON object
            Json json_obj = SplashKit.CreateJson();
            SplashKit.JsonSetString(json_obj, "name", "Breezy");

            // Check if the JSON object contains specific keys
            string key1 = "name";
            string key2 = "age";

            if (SplashKit.JsonHasKey(json_obj, key1))
            {
                SplashKit.WriteLine("Key '" + key1 + "' exists in the JSON object.");
            }
            else
            {
                SplashKit.WriteLine("Key '" + key1 + "' does not exist in the JSON object.");
            }

            if (SplashKit.JsonHasKey(json_obj, key2))
            {
                SplashKit.WriteLine("Key '" + key2 + "' exists in the JSON object.");
            }
            else
            {
                SplashKit.WriteLine("Key '" + key2 + "' does not exist in the JSON object.");
            }

            // Free the JSON object
            SplashKit.FreeJson(json_obj);
        }
    }
}