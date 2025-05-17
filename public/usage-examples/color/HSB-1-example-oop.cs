using SplashKitSDK;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            Window window = SplashKit.OpenWindow("HSB Color", 800, 600);

            double hue = 1;
            double saturation = 1;
            double brightness = 1;

            while (!SplashKit.WindowCloseRequested(window))
            {
                SplashKit.ProcessEvents();

                Vector2D scroll = SplashKit.MouseWheelScroll();
                Vector2D movement = SplashKit.MouseMovement();

                // Adjust hue by dragging with right mouse button
                if (SplashKit.MouseDown(MouseButton.LeftButton))
                {
                    hue += movement.X / SplashKit.ScreenWidth();
                    
                }

                saturation += scroll.Y / 10.0;
                    

                // Clear and draw
                
                Color color = SplashKit.HSBColor(hue, saturation, brightness);
                SplashKit.FillCircle(color, 400, 300, 300);

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}
