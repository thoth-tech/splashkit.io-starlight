using SplashKitSDK;

namespace SaturationOfExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Saturation Of", 800, 600);

            int randomRed = new Random().Next(0, 255);
            int randomGreen = new Random().Next(0, 255);
            int randomBlue = new Random().Next(0, 255);
            Color color = SplashKit.RGBAColor(randomRed, randomGreen, randomBlue, 255);
            // Function used here ↓
            double colorSaturation = SplashKit.SaturationOf(color);
            Rectangle rectangle = SplashKit.RectangleFrom(200, 100, 400, 300);

            SplashKit.ClearScreen(Color.White);
            SplashKit.FillRectangle(color, rectangle);
            SplashKit.DrawText("This color's saturation is " + colorSaturation.ToString(), Color.Black, 235, 450);
            SplashKit.DrawText("It's RGBA values are: R-" + randomRed.ToString() + ", G-" + randomGreen.ToString() + ", B-" + randomBlue.ToString() + ", A-255", Color.Black, 235, 470);
            SplashKit.RefreshScreen();

            SplashKit.Delay(5000);

            SplashKit.CloseAllWindows();
        }
    }
}