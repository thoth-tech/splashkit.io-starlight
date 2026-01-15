using SplashKitSDK;

namespace GetSystemFontExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("System Font Retriever and Displayer", 800, 600);

            // Set the font variable to the system's default font if available
            Font font = SplashKit.GetSystemFont();
            
            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen(Color.White);
                if (font != null)
                {
                    SplashKit.DrawText("System font detected!", Color.Black, 300, 100);

                    // Display some sample text to demonstrate the selected font
                    SplashKit.DrawText("The quick brown fox jumps over the lazy dog", Color.Black, font, 30, 50, 150);
                }
                else
                {
                    SplashKit.DrawText("No system font detected!", Color.Black, 300, 100);
                }
                SplashKit.RefreshScreen();
            }
            SplashKit.CloseAllWindows();
        }
    }
}