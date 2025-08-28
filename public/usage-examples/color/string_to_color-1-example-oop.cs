using SplashKitSDK;

namespace StringToColorExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("String To Color", 800, 600);

            // Change this string to get different colors 
            string color_hex = "#921e64d9";
            // Function used here ↓
            Color color = SplashKit.StringToColor(color_hex);
            int red_component = SplashKit.RedOf(color);
            int green_component = SplashKit.GreenOf(color);
            int blue_component = SplashKit.BlueOf(color);
            Rectangle rectangle = SplashKit.RectangleFrom(200, 100, 400, 300);

            SplashKit.ClearScreen(Color.White);
            SplashKit.FillRectangle(color, rectangle);
            SplashKit.DrawText("Current color's RGBA hex value is " + color_hex, Color.Black, 235, 450);
            SplashKit.DrawText("It's RGB values are: R-" + red_component.ToString() + ", G-" + green_component.ToString() + ", B-" + blue_component.ToString(), Color.Black, 235, 470);
            SplashKit.RefreshScreen();

            SplashKit.Delay(5000);

            SplashKit.CloseAllWindows();
        }
    }
}