using SplashKitSDK;

namespace GetSystemFont
{
    public class Program
    {
        public static void Main()
        {
            Window window = new Window("Get System Font", 800, 600);

            Font font = null;

            // The get system font function writes a font to this variable. If it is unable to find one, it won't write anything and the variable will remain blank
            font = SplashKit.GetSystemFont();
            
            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();
                if (font != null)
                {
                    SplashKit.DrawText("System font detected!", SplashKit.ColorBlack(), 300, 100);

                    // This line uses draw_text to give an example using this font
                    SplashKit.DrawText("The quick brown fox jumps over the lazy dog", SplashKit.ColorBlack(), font, 30, 50, 150);
                }
                else
                {
                    SplashKit.DrawText("No system font detected!", SplashKit.ColorBlack(), 300, 100);
                }
                SplashKit.RefreshScreen();
            }
            window.Close();
        }
    }
}