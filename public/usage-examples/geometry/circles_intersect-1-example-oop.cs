using SplashKitSDK;

namespace CirclesIntersectExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Circle Intersection Demo", 800, 600);

            Circle fixedCircle = SplashKit.CircleAt(350, 280, 100);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // Move the second circle with the mouse to test for intersections.
                Circle movableCircle = SplashKit.CircleAt(
                    SplashKit.MouseX(),
                    SplashKit.MouseY(),
                    70
                );

                // Check whether the two circles intersect.
                bool isIntersecting = SplashKit.CirclesIntersect(
                    fixedCircle,
                    movableCircle
                );

                SplashKit.ClearScreen(SplashKit.ColorWhite());

                if (isIntersecting)
                {
                    SplashKit.FillCircle(SplashKit.ColorRed(), fixedCircle);
                    SplashKit.FillCircle(SplashKit.ColorRed(), movableCircle);
                    SplashKit.DrawText(
                        "Circles are intersecting!",
                        SplashKit.ColorBlack(),
                        20,
                        20
                    );
                }
                else
                {
                    SplashKit.FillCircle(SplashKit.ColorBlue(), fixedCircle);
                    SplashKit.FillCircle(SplashKit.ColorGreen(), movableCircle);
                    SplashKit.DrawText(
                        "Circles are not intersecting.",
                        SplashKit.ColorBlack(),
                        20,
                        20
                    );
                }

                SplashKit.DrawText(
                    "Move the mouse-controlled circle over the fixed circle.",
                    SplashKit.ColorBlack(),
                    20,
                    550
                );

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}