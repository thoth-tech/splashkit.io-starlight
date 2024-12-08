using SplashKitSDK;

namespace JsonReadNumberInt
{
    public class Program
    {
        public static void Main()
        {
            // Create a JSON object with an integer value
            Json json_obj = SplashKit.CreateJson();
            SplashKit.JsonSetNumber(json_obj, "score", 100);

            // Read the integer value from the JSON object
            int score = (int)SplashKit.JsonReadNumberAsDouble(json_obj, "score");

            // Display the integer value
            SplashKit.WriteLine("Score: " + score.ToString());

            // Free the JSON object
            SplashKit.FreeJson(json_obj);
        }
    }
}