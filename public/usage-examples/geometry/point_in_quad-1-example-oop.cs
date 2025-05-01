using SplashKitSDK;

namespace PointInQuadExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Point In Quad", 800, 600);

            Color quadColor;
            string text;
            Quad quad = SplashKit.QuadFrom(SplashKit.PointAt(250, 180), SplashKit.PointAt(500, 210), SplashKit.PointAt(300, 380), SplashKit.PointAt(480, 480));
            
            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();
                Point2D cursorPos = SplashKit.MousePosition();

                // The text and quad colour is updated depending on whether cursor is inside the quad
                if (SplashKit.PointInQuad(cursorPos, quad))
                {
                    quadColor = Color.Green;
                    text = "Cursor in the quad!";
                }
                else
                {
                    quadColor = Color.Red;
                    text = "Cursor not in the quad!";
                }

                SplashKit.ClearScreen(Color.White);
                SplashKit.DrawQuad(quadColor, quad);
                SplashKit.DrawText(text, quadColor, 300, 100);
                SplashKit.RefreshScreen();
            }
            SplashKit.CloseAllWindows();
        }
    }
}