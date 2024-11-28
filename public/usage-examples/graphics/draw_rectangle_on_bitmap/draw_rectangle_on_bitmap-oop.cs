using SplashKitSDK;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Rectangle on Bitmap", 400, 400);
            Bitmap bitmap = new Bitmap("bricks", 400, 400);
        

        Random random = new Random();
        for (int i = 0; i < 50; i++)
        {
                double x = SplashKit.Rnd(50, 350);  // Random X position
                double y = SplashKit.Rnd(50, 350);  // Random Y position
                double width = SplashKit.Rnd(20, 50); // Random width
                double height = SplashKit.Rnd(20, 50); // Random height
                
            
            Color randcolor = SplashKit.RGBColor(
                SplashKit.Rnd(255), SplashKit.Rnd(255), SplashKit.Rnd(255)
            );

            bitmap.DrawRectangle(randcolor, x, y, width, height);
        }

           // Main loop to display the bitmap
            while(!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();
                SplashKit.DrawBitmap(bitmap, 0, 0);
                SplashKit.RefreshScreen();
            }

            // Free resources
            bitmap.Free();
        }
    }
}
