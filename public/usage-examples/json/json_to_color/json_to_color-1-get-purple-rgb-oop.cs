using SplashKitSDK;

namespace JsonToColor
{
    public class Program
    {
        public static void Main()
        {
            // Create a JSON object with a color string
            Json json_obj = SplashKit.CreateJson();
            SplashKit.JsonSetString(json_obj, "color", "#8040FFFF"); // Purple

            // Convert the JSON object to a color
            Color clr = SplashKit.JsonToColor(json_obj);

            // Display the color components
            SplashKit.WriteLine("Color created from JSON:");
            SplashKit.WriteLine("Red: " + SplashKit.RedOf(clr));
            SplashKit.WriteLine("Green: " + SplashKit.GreenOf(clr));
            SplashKit.WriteLine("Blue: " + SplashKit.BlueOf(clr));
            SplashKit.WriteLine("Alpha: " + SplashKit.AlphaOf(clr));

            // Free the JSON object
            SplashKit.FreeJson(json_obj);
        }
    }
}