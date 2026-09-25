using SplashKitSDK;
using static SplashKitSDK.SplashKit;

namespace DrawRectangleOnBitmapExample
{
    public class Program
    {
        public static void Main()
        {
            OpenWindow("Bitmap Canvas", 800, 600);

            Bitmap canvas = CreateBitmap("canvas", 500, 300);

            canvas.Clear(Color.White);

            canvas.DrawRectangle(Color.Red, 20, 20, 120, 80);
            canvas.DrawRectangle(Color.Blue, 170, 50, 150, 100);
            canvas.DrawRectangle(Color.Green, 360, 30, 100, 200);

            while (!QuitRequested())
            {
                ProcessEvents();
                ClearScreen(Color.LightGray);

                DrawText(
                    "These rectangles were drawn onto a bitmap first.",
                    Color.Black,
                    20,
                    20
                );

                DrawText(
                    "The bitmap is then drawn to the window.",
                    Color.Black,
                    20,
                    50
                );

                canvas.Draw(150, 180);

                RefreshScreen(60);
            }

            CloseAllWindows();
        }
    }
}
