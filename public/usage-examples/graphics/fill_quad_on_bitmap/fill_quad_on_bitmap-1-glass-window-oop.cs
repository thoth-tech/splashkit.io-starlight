using SplashKitSDK;

namespace FillQuadOnBitmap
{
    public class Program
    {
        public static void Main()
        {
            // Create a window and bitmap for the window
            Window window = new Window("Window", 400, 300);
            Bitmap bitmap = new Bitmap("window", 400, 300);

            // Fill background with white
            bitmap.Clear(Color.White);

            // Create color
            Color color = Color.RGBAColor(100, 150, 255, 128);

            // Size and spacing for squares
            double size = 80;
            double gap = 10;
            double start_x = 110;
            double start_y = 60;

            // Draw the four Window panels
            Quad[] panels = {
                SplashKit.QuadFrom(
                    start_x, start_y,
                    start_x + size, start_y,
                    start_x, start_y + size,
                    start_x + size, start_y + size
                ),
                SplashKit.QuadFrom(
                    start_x + size + gap, start_y,
                    start_x + size*2 + gap, start_y,
                    start_x + size + gap, start_y + size,
                    start_x + size*2 + gap, start_y + size
                ),
                SplashKit.QuadFrom(
                    start_x, start_y + size + gap,
                    start_x + size, start_y + size + gap,
                    start_x, start_y + size*2 + gap,
                    start_x + size, start_y + size*2 + gap
                ),
                SplashKit.QuadFrom(
                    start_x + size + gap, start_y + size + gap,
                    start_x + size*2 + gap, start_y + size + gap,
                    start_x + size + gap, start_y + size*2 + gap,
                    start_x + size*2 + gap, start_y + size*2 + gap
                )
            };

            // Draw each panel
            for (int i = 0; i < panels.Length; i++)
            {
                bitmap.FillQuad(color, panels[i]);
            }

            while (!window.CloseRequested)
            {
                SplashKit.ProcessEvents();
                // Draw the bitmap to the window
                window.DrawBitmap(bitmap, 0, 0);
                // Refresh the window
                SplashKit.RefreshScreen();
            }

            bitmap.Free();
        }
    }
}