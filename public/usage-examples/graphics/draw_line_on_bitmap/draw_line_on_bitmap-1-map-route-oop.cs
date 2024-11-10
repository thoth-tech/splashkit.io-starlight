using SplashKitSDK;

namespace DrawLineOnBitmap
{
    public class Program
    {
        public static void Main()
        {
            // Create a bitmap for the map
            Bitmap bitmap = new Bitmap("map", 400, 300);
            
            // Fill background with light beige for map background
            bitmap.ClearBitmap(Color.White);
            
            // Draw the route line in white
            bitmap.DrawLineOnBitmap(Color.Green, 
                                  100, 80,    // Starting point (x1, y1)
                                  300, 220);  // End point (x2, y2)
            
            // Add points at start and end
            bitmap.FillCircleOnBitmap(Color.Red, 100, 80, 5);    // Start point
            bitmap.FillCircleOnBitmap(Color.Red, 300, 220, 5);   // End point
            
            // Save and free the bitmap
            bitmap.SaveBitmap("map_route");
            bitmap.FreeBitmap();
        }
    }
}