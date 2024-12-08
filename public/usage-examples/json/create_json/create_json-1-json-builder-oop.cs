using SplashKitSDK;

namespace CreateJson
{
    public class program
    {
        public static void Main()
        {
            // Create an empty JSON object
            Json jsonObj = SplashKit.CreateJson();

            // Add some data to the JSON object
            SplashKit.JsonSetString(jsonObj, "name", "Breezy");
            SplashKit.JsonSetNumber(jsonObj, "age", 25);

            // Display the JSON object as a string
            SplashKit.WriteLine("Created JSON: " + SplashKit.JsonToString(jsonObj));
        }
    }
}