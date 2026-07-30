using SplashKitSDK;

namespace RectanglesIntersectExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Rectangle Intersection Demo", 800, 600);

            Rectangle fixedRectangle = SplashKit.RectangleFrom(
                300,
                220,
                200,
                120
            );

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // Move the second rectangle with the mouse to test for intersections.
                Rectangle movableRectangle = SplashKit.RectangleFrom(
                    SplashKit.MouseX() - 75,
                    SplashKit.MouseY() - 50,
                    150,
                    100
                );

                // Check whether the two rectangles intersect.
                bool isIntersecting = SplashKit.RectanglesIntersect(
                    fixedRectangle,
                    movableRectangle
                );

                SplashKit.ClearScreen(Color.White);

                if (isIntersecting)
                {
                    SplashKit.FillRectangle(Color.Red, fixedRectangle);
                    SplashKit.FillRectangle(Color.Red, movableRectangle);

                    SplashKit.DrawText(
                        "Rectangles are intersecting.",
                        Color.Black,
                        240,
                        60
                    );
                }
                else
                {
                    SplashKit.FillRectangle(Color.Blue, fixedRectangle);
                    SplashKit.FillRectangle(Color.Green, movableRectangle);

                    SplashKit.DrawText(
                        "Move the green rectangle with the mouse.",
                        Color.Black,
                        185,
                        60
                    );
                }

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}