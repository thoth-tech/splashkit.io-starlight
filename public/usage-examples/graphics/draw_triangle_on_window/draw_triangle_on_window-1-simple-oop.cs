using SplashKitSDK;

namespace DrawCircleOnWindowExample
{
    public class Program
    {
        public static void Main()
        {
            Window window = new Window("Draw Triangle on Window", 800, 600);
            window.Clear(Color.White);

            for (int i = 0; i < 20; i++)
            {
                // Set the x position for triangles increase by 40 * i every round
                double x = 40 * i;

                Color randomColor = SplashKit.RGBColor(
                    SplashKit.Rnd(255), SplashKit.Rnd(255), SplashKit.Rnd(255)
                );

                // Draw the triangles by increasing x position
                SplashKit.DrawTriangleOnWindow(window, randomColor, 0 + x, 0, 20 + x, 40, 40 + x, 0);
            }

            window.Refresh();
            SplashKit.Delay(4000);
            window.Close();
        }
    }
}

