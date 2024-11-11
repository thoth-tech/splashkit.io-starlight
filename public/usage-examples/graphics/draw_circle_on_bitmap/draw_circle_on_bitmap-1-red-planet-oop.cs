using SplashKitSDK;
using static SplashKitSDK.SplashKit;

namespace DrawCircleOnBitmap
{
    public class Program
    {
        public static void Main()
        {
            // Create a bitmap to draw on
            Bitmap planet = new Bitmap("planet", 400, 400);

            // Fill background with dark color
            planet.Clear(Color.Black);

            // Create color
            Color red = Color.Red;

            // Draw the main planet circle
            planet.FillCircle(Color.RGBAColor(180, 0, 0, 255), 200, 200, 150);
            planet.DrawCircle(red, 200, 200, 150);

            // Add some surface details with smaller circles
            for (int i = 0; i < 15; i++)
            {
                double x = Rnd(100, 300);  // Random between 100 and 300
                double y = Rnd(100, 300);   // Random between 100 and 300
                double size = Rnd(10, 30);  // Random between 10 and 30
                planet.DrawCircle(red, x, y, size);
            }

            // Save and free the bitmap
            SaveBitmap(planet, "draw_circle_on_bitmap-1-red-planet");
            planet.Free();
        }
    }
}