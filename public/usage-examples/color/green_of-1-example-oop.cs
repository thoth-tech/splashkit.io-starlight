using SplashKitSDK;

namespace GreenOfExample
{
    public class Program
    {
        public static void Main()
        {
            Window window = new Window(
                "Green Channel Shades",
                700,
                450
            );

            Color lowGreen = Color.RGBColor(80, 30, 120);
            Color mediumGreen = Color.RGBColor(80, 130, 120);
            Color highGreen = Color.RGBColor(80, 230, 120);

            window.Clear(Color.White);

            window.FillRectangle(lowGreen, 80, 70, 180, 80);
            window.DrawText(
                "Green value: " + SplashKit.GreenOf(lowGreen),
                Color.Black,
                300,
                100
            );

            window.FillRectangle(mediumGreen, 80, 180, 180, 80);
            window.DrawText(
                "Green value: " + SplashKit.GreenOf(mediumGreen),
                Color.Black,
                300,
                210
            );

            window.FillRectangle(highGreen, 80, 290, 180, 80);
            window.DrawText(
                "Green value: " + SplashKit.GreenOf(highGreen),
                Color.Black,
                300,
                320
            );

            window.Refresh();
            SplashKit.Delay(5000);

            window.Close();
        }
    }
}