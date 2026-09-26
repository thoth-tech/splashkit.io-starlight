using SplashKitSDK;

namespace ColorHotPinkExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Hot Pink Colour Showcase", 800, 600);

            // Store the named colour once so every shape uses the same value.
            Color hotPink = SplashKit.ColorHotPink();

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                SplashKit.ClearScreen(Color.DarkSlateGray);

                // Repeat the colour across different shapes to showcase the result.
                SplashKit.FillRectangle(hotPink, 160, 120, 480, 260);
                SplashKit.FillCircle(hotPink, 280, 455, 55);
                SplashKit.FillCircle(hotPink, 400, 455, 55);
                SplashKit.FillCircle(hotPink, 520, 455, 55);

                SplashKit.DrawText("HOT PINK COLOUR SHOWCASE", Color.White, 270, 65);
                SplashKit.DrawText("Created with SplashKit.ColorHotPink()", Color.White, 270, 535);

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}
