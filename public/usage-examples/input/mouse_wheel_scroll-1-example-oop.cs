using SplashKitSDK;

namespace MouseWheelScrollExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Mouse Wheel Scroll", 800, 600);

            int x_scroll_counter = 0;
            int y_scroll_counter = 0;
            Font font = SplashKit.FontNamed("Century.ttf");

            while (!SplashKit.QuitRequested())
            {
                x_scroll_counter += (int)SplashKit.MouseWheelScroll().X;
                y_scroll_counter += (int)SplashKit.MouseWheelScroll().Y;

                SplashKit.ProcessEvents();

                SplashKit.ClearScreen(Color.White);
                SplashKit.DrawText(x_scroll_counter + ", " + y_scroll_counter, Color.Black, font, 200, 400 - SplashKit.TextWidth(x_scroll_counter + ", " + y_scroll_counter, font, 200) / 2, 90);
                SplashKit.DrawText("Reading is affected by moving the scroll wheel", Color.Black, font, 15, 248, 400);
                SplashKit.RefreshScreen();
            }
            SplashKit.CloseAllWindows();
        }
    }
}