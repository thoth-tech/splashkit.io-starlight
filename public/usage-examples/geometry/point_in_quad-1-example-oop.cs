using SplashKitSDK;

namespace PointInQuad
{
    public class Program
    {
        public static void Main()
        {
            Window window = new Window("Point In Quad", 800, 600);

            Point2D cursor_pos;
            Color quad_clr;
            string text;
            Quad quad = SplashKit.QuadFrom(SplashKit.PointAt(250, 180), SplashKit.PointAt(500, 210), SplashKit.PointAt(300, 380), SplashKit.PointAt(480, 480));
            
            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();
                cursor_pos = SplashKit.MousePosition();

                // The text and quad colour is updated depending on whether cursor is inside the quad
                if (SplashKit.PointInQuad(cursor_pos, quad))
                {
                    quad_clr = Color.Green;
                    text = "Cursor in the quad!";
                }
                else
                {
                    quad_clr = Color.Red;
                    text = "Cursor not in the quad!";
                }

                SplashKit.ClearScreen();
                SplashKit.DrawQuad(quad_clr, quad);
                SplashKit.DrawText(text, quad_clr, 300, 100);
                SplashKit.RefreshScreen();
            }
            window.Close();
        }
    }
}