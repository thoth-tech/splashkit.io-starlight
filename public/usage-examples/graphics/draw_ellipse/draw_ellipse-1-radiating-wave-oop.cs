using SplashKitSDK;

namespace DrawEllipseExample
{
    public class Program
    {
        public static void Main()
        {
            Window window = new Window("Draw Ellipse", 800, 600);
            window.Clear(Color.White);

            // Draw 30 ellipses
            for (int i = 0; i < 30; i++)
            {
                // Decrease width by 20 every round
                int width = 600 - i * 20;
                // Decrease height by 10 every round
                int height = 400 - i * 10;
                // Increase x position by 10 every round
                int x = 100 + i * 10;
                // Increase y position by 5 every round
                int y = 100 + i * 5;

                Color randomColor = SplashKit.RGBColor(
                    SplashKit.Rnd(255), SplashKit.Rnd(255), SplashKit.Rnd(255)
                );

                // Draw ellipse based on the given data
                SplashKit.DrawEllipse(randomColor, x, y, width, height);
            }

            window.Refresh();
            SplashKit.Delay(4000);
            window.Close();
        }
    }
}

