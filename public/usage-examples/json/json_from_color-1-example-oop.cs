using SplashKitSDK;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            // Create a color
            Color clr = Color.Black;

            // Convert the color to a JSON object
            Json json_object = SplashKit.JsonFromColor(clr);

            // Display the JSON object as a string
            SplashKit.WriteLine("JSON from Color: " + SplashKit.JsonToString(json_object));

        }
    }
}
