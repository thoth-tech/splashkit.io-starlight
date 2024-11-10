using SplashKitSDK;

namespace DrawTriangleOnBitmap
{
    public class Program
    {
        public static void Main()
        {
            // Create a bitmap for the mountain scene
            Bitmap bitmap = new Bitmap("mountain", 400, 300);
            
            // Fill background with light color
            bitmap.ClearBitmap(Color.White);
            
            // Draw right peak (smallest)
            bitmap.DrawTriangleOnBitmap(Color.Gray, 
                                      175, 250,   // Left base
                                      275, 175,   // Peak
                                      375, 250);  // Right base
            
            // Draw left peak (medium)
            bitmap.DrawTriangleOnBitmap(Color.Gray,
                                      25, 250,    // Left base
                                      125, 125,   // Peak
                                      225, 250);  // Right base
            
            // Draw center peak (tallest)
            bitmap.DrawTriangleOnBitmap(Color.Gray,
                                      100, 250,   // Left base
                                      200, 100,   // Peak
                                      300, 250);  // Right base
            
            // Save and free the bitmap
            bitmap.SaveBitmap("mountain_peaks");
            bitmap.FreeBitmap();
        }
    }
}