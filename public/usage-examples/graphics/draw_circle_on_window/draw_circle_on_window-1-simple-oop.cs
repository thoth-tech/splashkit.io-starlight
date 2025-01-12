using SplashKitSDK;

namespace DrawCircleOnWindowExample
{
    public class Program
    {
        public static void Main()
        {
            Window window = new Window("Draw Circle on Window", 800, 600);
            window.Clear(Color.White);

            for (int i = 0; i < 50; i++)
            {
                // Set random x position to 1 - 800
                double x = SplashKit.Rnd(800);

                // Set random y position to 1 - 600
                double y = SplashKit.Rnd(600);

                // Set random radius to 1 - 50
                double radius = SplashKit.Rnd(50);

                Color randomColor = SplashKit.RGBColor(
                    SplashKit.Rnd(255), SplashKit.Rnd(255), SplashKit.Rnd(255)
                );

                // Draw the circle base on the random data
                SplashKit.DrawCircleOnWindow(window, randomColor, x, y, radius);
            }

            window.Refresh();
            SplashKit.Delay(4000);
            window.Close();
        }
    }
}

