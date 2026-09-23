using SplashKitSDK;

namespace CircleTriangleIntersectExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Intruder Alert!!", 800, 600);

            // Declaring variables
            Point2D p1 = SplashKit.PointAt(400, 200);
            Point2D p2 = SplashKit.PointAt(300, 400);
            Point2D p3 = SplashKit.PointAt(500, 400);
            Triangle house = SplashKit.TriangleFrom(p1, p2, p3);
            Point2D cursorPosition;
            Circle intruder;
            Color flash = Color.Red;

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // Get mouse position
                cursorPosition = SplashKit.MousePosition();
                intruder = SplashKit.CircleAt(cursorPosition, 20);

                if (SplashKit.CircleTriangleIntersect(intruder, house))
                {
                    SplashKit.ClearScreen(flash);
                    SplashKit.DrawText("House Breached!!", Color.Black, 350, 100);

                    // Toggle flash color
                    if (flash == Color.Red)
                    {
                        flash = Color.Blue;
                    }
                    else
                    {
                        flash = Color.Red;
                    }
                    SplashKit.Delay(500);
                }
                else
                {
                    SplashKit.ClearScreen(Color.White);
                }

                SplashKit.DrawTriangle(Color.Black, house);
                SplashKit.FillCircle(Color.Black, intruder);
                SplashKit.RefreshScreen();
            }
            SplashKit.CloseAllWindows();
        }
    }
}
