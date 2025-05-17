using SplashKitSDK;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            Window window = SplashKit.OpenWindow("Random Color", 800, 600);

            // Store the original and current color
            Color originalColor = SplashKit.RandomColor();
            Color currentColor = originalColor;

            
            while (!SplashKit.WindowCloseRequested(window))
            {
                SplashKit.ProcessEvents();
                // Left click: change to a new random color
                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    currentColor = SplashKit.RandomColor();
                }

                // Right click: return to original color
                if (SplashKit.MouseClicked(MouseButton.RightButton))
                {
                    currentColor = originalColor;
                }
                SplashKit.ClearScreen(currentColor);
                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}

