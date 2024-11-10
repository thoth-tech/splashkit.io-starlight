using SplashKitSDK;

namespace FillCircleOnBitmap
{
    public class Program
    {
        public static void Main()
        {
            // Create a bitmap for our caterpillar
            Bitmap bitmap = new Bitmap("caterpillar", 400, 200);
            
            // Create rainbow colors array
            Color[] colors = { Color.Red, Color.Orange, Color.Yellow, 
                             Color.Green, Color.Blue, Color.Violet };
            
            // Draw circles for caterpillar segments with alternating y positions
            double x = 50;
            for(int i = 0; i < colors.Length; i++)
            {
                double y = 100 + (i % 2 == 0 ? 20 : -20);  // Alternate up and down
                bitmap.FillCircleOnBitmap(colors[i], x, y, 40);
                x += 60;
            }
            
            // Draw eyes (adjusted to match first segment position)
            bitmap.FillCircleOnBitmap(Color.Black, 60, 100, 8);
            bitmap.FillCircleOnBitmap(Color.Black, 60, 130, 8);
            
            // Save and free the bitmap
            bitmap.SaveBitmap("rainbow_caterpillar");
            bitmap.FreeBitmap();
        }
    }
}