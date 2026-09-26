using SplashKitSDK;

namespace ScreenRectangleExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Screen Rectangle", 640, 480);

            Rectangle screen = SplashKit.ScreenRectangle();

            SplashKit.ClearScreen(SplashKit.ColorWhite());

            SplashKit.FillRectangle(
                SplashKit.ColorLightBlue(),
                screen.X,
                screen.Y,
                screen.Width,
                screen.Height
            );

            SplashKit.DrawRectangle(
                SplashKit.ColorDarkBlue(),
                screen.X,
                screen.Y,
                screen.Width,
                screen.Height
            );

            SplashKit.DrawText(
                "screen_rectangle() represents the current window area",
                SplashKit.ColorBlack(),
                30,
                40
            );

            SplashKit.DrawText(
                "Window size: 640 x 480",
                SplashKit.ColorBlack(),
                30,
                75
            );

            SplashKit.RefreshScreen();

            SplashKit.Delay(4000);

            SplashKit.CloseAllWindows();
        }
    }
}
