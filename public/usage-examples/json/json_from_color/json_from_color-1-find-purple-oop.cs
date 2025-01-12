using SplashKitSDK;

namespace FromColor
{
    public class Program
    {
        public static void Main()
        {
            // Create a color
            Color clr = Color.Purple;

            // Convert the color to a JSON object
            Json json_obj = SplashKit.JsonFromColor(clr);

            // Display the JSON object as a string
            SplashKit.WriteLine("JSON from Color: " + SplashKit.JsonToString(json_obj));

            // Free the JSON object
            SplashKit.FreeJson(json_obj);
        }
    }
}