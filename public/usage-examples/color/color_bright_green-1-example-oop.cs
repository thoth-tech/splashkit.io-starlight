using SplashKitSDK;

namespace ColorBrightGreenExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Color Bright Green", 300, 540);

            SplashKit.ClearScreen(Color.White);

            // The body of the traffic light
            SplashKit.FillRectangle(Color.Black, 60, 40, 180, 420);

            // The red and amber lights are switched off, so they are drawn dark gray
            SplashKit.FillCircle(Color.DarkGray, 150, 110, 50);
            SplashKit.FillCircle(Color.DarkGray, 150, 250, 50);

            // The green light is on - Color.BrightGreen stands out against the black body
            // Function used here ↓
            SplashKit.FillCircle(Color.BrightGreen, 150, 390, 50);

            SplashKit.DrawText("GO - Color.BrightGreen", Color.BrightGreen, 70, 490);

            SplashKit.RefreshScreen();

            SplashKit.Delay(5000);

            SplashKit.CloseAllWindows();
        }
    }
}
