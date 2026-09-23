using SplashKitSDK;

namespace TriangleRayIntersectionExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Triangle Ray Intersection", 800, 600);

            Point2D rayOrigin = SplashKit.PointAt(120, 300);

            Triangle tri = SplashKit.TriangleFrom(
                SplashKit.PointAt(500, 180),
                SplashKit.PointAt(650, 420),
                SplashKit.PointAt(420, 420)
            );

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                Point2D mouse = SplashKit.MousePosition();

                Vector2D heading = SplashKit.VectorTo(
                    mouse.X - rayOrigin.X,
                    mouse.Y - rayOrigin.Y
                );

                bool intersects = SplashKit.TriangleRayIntersection(
                    rayOrigin,
                    heading,
                    tri
                );

                SplashKit.ClearScreen(Color.White);

                if (intersects)
                {
                    SplashKit.FillTriangle(Color.Green, tri);

                    SplashKit.DrawText(
                        "Ray intersects the triangle",
                        Color.Green,
                        20,
                        20
                    );
                }
                else
                {
                    SplashKit.FillTriangle(Color.Red, tri);

                    SplashKit.DrawText(
                        "Ray does not intersect the triangle",
                        Color.Red,
                        20,
                        20
                    );
                }

                SplashKit.DrawTriangle(Color.Black, tri);

                SplashKit.DrawCircle(
                    Color.Blue,
                    rayOrigin.X,
                    rayOrigin.Y,
                    6
                );

                double rayLength = 1000;

                Point2D rayEnd = SplashKit.PointAt(
                    rayOrigin.X + heading.X * rayLength,
                    rayOrigin.Y + heading.Y * rayLength
                );

                SplashKit.DrawLine(
                    Color.Blue,
                    rayOrigin.X,
                    rayOrigin.Y,
                    rayEnd.X,
                    rayEnd.Y
                );

                SplashKit.DrawText(
                    "Move the mouse to change the ray direction",
                    Color.Black,
                    20,
                    550
                );

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}
