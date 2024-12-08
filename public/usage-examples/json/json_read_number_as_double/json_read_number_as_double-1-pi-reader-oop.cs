using SplashKitSDK;

namespace JsonReadNumberDouble
{
    public class Program
    {
        public static void Main()
        {
            // Create a JSON object with a double number
            Json json_obj = SplashKit.CreateJson();
            SplashKit.JsonSetNumber(json_obj, "pi", 3.14159);

            // Read the double value from the JSON object
            double pi = SplashKit.JsonReadNumberAsDouble(json_obj, "pi");

            // Display the double value
            SplashKit.WriteLine("Pi: " + pi.ToString());

            // Free the JSON object
            SplashKit.FreeJson(json_obj);
        }
    }
}