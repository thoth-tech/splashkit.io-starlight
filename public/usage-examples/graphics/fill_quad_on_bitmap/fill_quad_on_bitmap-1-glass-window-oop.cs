using SplashKitSDK;

namespace FillQuadOnBitmap
{
    public class Program
    {
        public static void Main()
        {
            // Create a bitmap for the window
            Bitmap bitmap = new Bitmap("window", 400, 300);
            
            // Fill background with white
            bitmap.ClearBitmap(Color.White);
            
            // Create color
            Color color = Color.RGBAColor(100, 150, 255, 128);
            
            // Size and spacing for squares
            double size = 80;
            double gap = 10;
            double start_x = 110;
            double start_y = 60;
            
            // Draw the four Window panels
            Quad[] panels = {
                QuadFrom(
                    start_x, start_y,
                    start_x + size, start_y,
                    start_x, start_y + size,
                    start_x + size, start_y + size
                ),
                QuadFrom(
                    start_x + size + gap, start_y,
                    start_x + size*2 + gap, start_y,
                    start_x + size + gap, start_y + size,
                    start_x + size*2 + gap, start_y + size
                ),
                QuadFrom(
                    start_x, start_y + size + gap,
                    start_x + size, start_y + size + gap,
                    start_x, start_y + size*2 + gap,
                    start_x + size, start_y + size*2 + gap
                ),
                QuadFrom(
                    start_x + size + gap, start_y + size + gap,
                    start_x + size*2 + gap, start_y + size + gap,
                    start_x + size + gap, start_y + size*2 + gap,
                    start_x + size*2 + gap, start_y + size*2 + gap
                )
            };
            
            // Draw each panel
            for(int i = 0; i < 4; i++)
            {
                bitmap.FillQuadOnBitmap(color, panels[i]);
            }
            
            // Save and free the bitmap
            bitmap.SaveBitmap("glass_window");
            bitmap.FreeBitmap();
        }
    }
}