using SplashKitSDK;

namespace BitmapBoundingRectangleExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Bitmap Bounding Rectangle", 800, 600);

            int refreshCounter = 0;
            Point2D verticalBitmapPos = SplashKit.PointAt(0, 0);
            Point2D horizontalBitmapPos = SplashKit.PointAt(0, 0);
            Rectangle bitmapRectangle = SplashKit.RectangleFrom(0, 0, 0, 0);;
            Bitmap verticalBitmap = SplashKit.LoadBitmap("verticalBitmap", "image1.jpeg");
            Bitmap horizontalBitmap = SplashKit.LoadBitmap("horizontalBitmap", "image2.png");

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                refreshCounter += 1;
                if (refreshCounter <= 15000)
                {
                    //Function used here ↓
                    bitmapRectangle = SplashKit.BitmapBoundingRectangle(verticalBitmap);
                    verticalBitmapPos = SplashKit.PointAt(200, 120);
                    horizontalBitmapPos = SplashKit.PointAt(1000, 1000);
                    bitmapRectangle.X = 450;
                    bitmapRectangle.Y = 120;
                }
                else if (refreshCounter > 15000 && refreshCounter <= 30000)
                {
                    //Function used here ↓
                    bitmapRectangle = SplashKit.BitmapBoundingRectangle(horizontalBitmap);
                    verticalBitmapPos = SplashKit.PointAt(1000, 1000);
                    horizontalBitmapPos = SplashKit.PointAt(150, 243);
                    bitmapRectangle.X = 450;
                    bitmapRectangle.Y = 243;
                }
                else
                {
                    refreshCounter = 0;
                }

                SplashKit.ClearScreen(Color.White);

                SplashKit.DrawRectangle(Color.Black, bitmapRectangle);
                SplashKit.DrawBitmap(vertical_bitmap, verticalBitmapPos.X, verticalBitmapPos.Y);
                SplashKit.DrawBitmap(horizontal_bitmap, horizontalBitmapPos.X, horizontalBitmapPos.Y);

                SplashKit.RefreshScreen();
            }
            SplashKit.CloseAllWindows();
        }
    }
}