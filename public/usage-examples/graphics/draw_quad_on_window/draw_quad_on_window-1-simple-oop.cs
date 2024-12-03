using SplashKitSDK;

namespace DrawQuadOnWindow
{
    public class Program
    {
        public static void Main()
        {
            // Initialise quads with x1, y1,..., x4, y4
            Quad Q1 = SplashKit.QuadFrom(400, 200, 300, 300, 300, 0, 200, 200);
            Quad Q2 = SplashKit.QuadFrom(400, 210, 310, 300, 600, 300, 400, 390);
            Quad Q3 = SplashKit.QuadFrom(200, 400, 300, 300, 300, 600, 400, 400);
            Quad Q4 = SplashKit.QuadFrom(200, 390, 290, 300, 0, 300, 200, 210);

            // Create Windows
            Window Window1 = SplashKit.OpenWindow("Diamonds On Window 1", 600, 600);
            Window Window2 = SplashKit.OpenWindow("Diamonds On Window 2", 600, 600);
            SplashKit.ClearScreen(SplashKit.ColorWhite());

            Window1.DrawQuad(Color.Black, Q1);
            Window1.DrawQuad(Color.Green, Q2);
            Window2.DrawQuad(Color.Red, Q3);
            Window2.DrawQuad(Color.Blue, Q4);

            SplashKit.RefreshScreen();
            SplashKit.Delay(5000);
            SplashKit.CloseAllWindows();
        }
    }
}