using SplashKitSDK;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            // Create a JSON object
            Json json_object = SplashKit.CreateJson();

            // Add some data to the JSON object
            SplashKit.JsonSetString(json_object, "frist_name", "Lam");
            SplashKit.JsonSetString(json_object, "last_name", "Huynh");

            // Count the keys in the JSON object
            int key_count = SplashKit.JsonCountKeys(json_object);

            // Display the count of keys
            SplashKit.WriteLine("The JSON object has " + key_count.ToString() + " keys.");
        }
    }
}