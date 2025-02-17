using SplashKitSDK;

namespace DrawTriangleExample
{
    public class Program
    {
        public static void Main()
        {
            Window window = new Window("Draw Triangle", 800, 600);
            window.Clear(Color.White);

            for (int i = 0; i < 10; i++)
            {
                // Random point 1 for the trangle (x1,y1)
                int x1 = SplashKit.Rnd(800);
                int y1 = SplashKit.Rnd(600);

                // Random point 2 for the trangle (x2,y2)
                int x2 = SplashKit.Rnd(800);
                int y2 = SplashKit.Rnd(600);

                // Random point 3 for the trangle (x3,y3)
                int x3 = SplashKit.Rnd(800);
                int y3 = SplashKit.Rnd(600);

                Color randomColor = SplashKit.RGBColor(
                    SplashKit.Rnd(255), SplashKit.Rnd(255), SplashKit.Rnd(255)
                );

                // Draw trangle base on the three random points
                SplashKit.DrawTriangle(randomColor, x1, y1, x2, y2, x3, y3);
            }

            window.Refresh();
            SplashKit.Delay(4000);
            window.Close();
        }
    }
}

