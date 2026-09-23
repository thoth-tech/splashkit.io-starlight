using SplashKitSDK;

namespace BitmapBoundingRectangleExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Bitmap Bounding Rectangle", 800, 600);

            Bitmap vertical_bitmap = SplashKit.LoadBitmap("vertical_bitmap", "image1.jpeg");
            Bitmap horizontal_bitmap = SplashKit.LoadBitmap("horizontal_bitmap", "image2.png");
            // Function used here ↓
            Rectangle vertical_rectangle = SplashKit.BitmapBoundingRectangle(vertical_bitmap);
            Rectangle horizontal_rectangle = SplashKit.BitmapBoundingRectangle(horizontal_bitmap);

            vertical_rectangle.X = 212;
            vertical_rectangle.Y = 50;
            horizontal_rectangle.X = 150;
            horizontal_rectangle.Y = 400;

            SplashKit.ProcessEvents();

            SplashKit.ClearScreen(Color.White);
            SplashKit.DrawBitmap(vertical_bitmap, 450, 50);
            SplashKit.DrawRectangle(Color.Black, vertical_rectangle);
            SplashKit.DrawBitmap(horizontal_bitmap, 450, 400);
            SplashKit.DrawRectangle(Color.Black, horizontal_rectangle);
            SplashKit.RefreshScreen();

            SplashKit.Delay(5000);

            SplashKit.CloseAllWindows();
        }
    }
}