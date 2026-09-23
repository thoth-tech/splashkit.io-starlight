using SplashKitSDK;

namespace RedOfExample
{
    public class Program
    {
        public static void Main()
        {
            Window window = new Window(
                "Red Channel Shades",
                700,
                450
            );

            Color lowRed = Color.RGBColor(30, 80, 120);
            Color mediumRed = Color.RGBColor(130, 80, 120);
            Color highRed = Color.RGBColor(230, 80, 120);

            window.Clear(Color.White);

            window.FillRectangle(lowRed, 80, 70, 180, 80);
            window.DrawText(
                "Red value: " + SplashKit.RedOf(lowRed),
                Color.Black,
                300,
                100
            );

            window.FillRectangle(mediumRed, 80, 180, 180, 80);
            window.DrawText(
                "Red value: " + SplashKit.RedOf(mediumRed),
                Color.Black,
                300,
                210
            );

            window.FillRectangle(highRed, 80, 290, 180, 80);
            window.DrawText(
                "Red value: " + SplashKit.RedOf(highRed),
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