using SplashKitSDK;

namespace ColorBlackExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Color Black", 600, 500);

            SplashKit.ClearScreen(Color.White);

            // Draw an 8 x 8 checkerboard
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    // Fill every second square, leaving the others white
                    if ((row + col) % 2 == 0)
                    {
                        // Function used here ↓
                        SplashKit.FillRectangle(Color.Black, 100 + col * 50, 60 + row * 50, 50, 50);
                    }
                }
            }

            // Color.Black is also useful for drawing text on a light background
            SplashKit.DrawText("A checkerboard drawn with Color.Black", Color.Black, 175, 25);

            SplashKit.RefreshScreen();

            SplashKit.Delay(5000);

            SplashKit.CloseAllWindows();
        }
    }
}
