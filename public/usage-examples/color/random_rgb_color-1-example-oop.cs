using SplashKitSDK;

namespace RandomRgbColorExample
{
    public class Program
    {
        public static void Main()
        {
            // Open a window to display the random colours
            Window wind = SplashKit.OpenWindow("Random Colour Grid", 640, 480);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // Clear the screen before drawing
                SplashKit.ClearWindow(wind, SplashKit.ColorWhite());

                // Draw a grid of squares with random colours
                for (int row = 0; row < 4; row++)
                {
                    for (int col = 0; col < 4; col++)
                    {
                        Color randomColour = SplashKit.RandomRgbColor(255);

                        SplashKit.FillRectangle(randomColour, 80 + col * 120, 80 + row * 80, 80, 50);
                        SplashKit.DrawRectangle(SplashKit.ColorBlack(), 80 + col * 120, 80 + row * 80, 80, 50);
                    }
                }

                // Add a label to explain the example
                SplashKit.DrawText("Each square uses RandomRgbColor()", SplashKit.ColorBlack(), 150, 420);

                // Refresh the window to show updated colours
                SplashKit.RefreshWindow(wind);
            }

            // Close the window when the program ends
            SplashKit.CloseAllWindows();
        }
    }
}