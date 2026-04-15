using SplashKitSDK;
using static SplashKitSDK.SplashKit;

namespace DrawRectangleOnBitmapExample
{
    public class Program
    {
        public static void Main()
        {
            OpenWindow("Draw Rectangle On Bitmap", 800, 600);

            // Create a bitmap that will act as a drawing canvas
            Bitmap canvas = CreateBitmap("canvas", 500, 300);

            // Fill the bitmap so it stands out from the window background
            ClearBitmap(canvas, ColorWhite());

            // Draw rectangles onto the bitmap
            DrawRectangleOnBitmap(canvas, ColorRed(), 20, 20, 120, 80);
            DrawRectangleOnBitmap(canvas, ColorBlue(), 170, 50, 150, 100);
            DrawRectangleOnBitmap(canvas, ColorGreen(), 360, 30, 100, 200);

            while (!QuitRequested())
            {
                ProcessEvents();
                ClearScreen(ColorLightGray());

                // Explain what the example is showing
                DrawText(
                    "These rectangles were drawn onto a bitmap first.",
                    ColorBlack(),
                    20,
                    20
                );
                DrawText(
                    "The bitmap is then drawn to the window.",
                    ColorBlack(),
                    20,
                    50
                );

                // Display the bitmap on the screen
                DrawBitmap(canvas, 150, 180);

                RefreshScreen(60);
            }

            CloseAllWindows();
        }
    }
}