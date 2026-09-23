using SplashKitSDK;

namespace VectorFromAngleExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Vector From Angle", 800, 600);

            double angle = 0;
            const double length = 180;

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                if (SplashKit.KeyDown(KeyCode.LeftKey))
                {
                    angle -= 2;
                }

                if (SplashKit.KeyDown(KeyCode.RightKey))
                {
                    angle += 2;
                }

                Point2D center = new Point2D()
                {
                    X = SplashKit.ScreenWidth() / 2,
                    Y = SplashKit.ScreenHeight() / 2
                };

                Vector2D direction =
                    SplashKit.VectorFromAngle(angle, length);

                Point2D endPoint = new Point2D()
                {
                    X = center.X + direction.X,
                    Y = center.Y + direction.Y
                };

                SplashKit.ClearScreen(Color.Black);

                SplashKit.DrawLine(
                    Color.Blue,
                    center.X,
                    center.Y,
                    endPoint.X,
                    endPoint.Y
                );

                SplashKit.FillCircle(
                    Color.Yellow,
                    endPoint.X,
                    endPoint.Y,
                    10
                );

                SplashKit.FillCircle(
                    Color.White,
                    center.X,
                    center.Y,
                    6
                );

                SplashKit.DrawText(
                    $"Angle: {angle:0} degrees",
                    Color.White,
                    20,
                    20
                );

                SplashKit.DrawText(
                    "Use Left and Right Arrow Keys",
                    Color.LightGray,
                    20,
                    50
                );

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}