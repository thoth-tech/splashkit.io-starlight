using SplashKitSDK;

namespace TrianglesIntersectExample
{
    public class Program
    {
        public static void Main()
        {
            Window window = new Window(
                "Moving Triangle Intersection",
                800,
                600
            );

            Triangle fixedTriangle = SplashKit.TriangleFrom(
                SplashKit.PointAt(250, 200),
                SplashKit.PointAt(400, 150),
                SplashKit.PointAt(350, 350)
            );

            while (!window.CloseRequested)
            {
                SplashKit.ProcessEvents();

                Point2D mousePoint = SplashKit.MousePosition();

                Triangle movingTriangle = SplashKit.TriangleFrom(
                    SplashKit.PointAt(
                        mousePoint.X,
                        mousePoint.Y - 60
                    ),
                    SplashKit.PointAt(
                        mousePoint.X - 60,
                        mousePoint.Y + 40
                    ),
                    SplashKit.PointAt(
                        mousePoint.X + 60,
                        mousePoint.Y + 40
                    )
                );

                window.Clear(Color.White);

                window.DrawTriangle(
                    Color.Blue,
                    fixedTriangle
                );

                if (
                    SplashKit.TrianglesIntersect(
                        fixedTriangle,
                        movingTriangle
                    )
                )
                {
                    window.DrawTriangle(
                        Color.Red,
                        movingTriangle
                    );
                    window.DrawText(
                        "The triangles intersect",
                        Color.Red,
                        250,
                        50
                    );
                }
                else
                {
                    window.DrawTriangle(
                        Color.Green,
                        movingTriangle
                    );
                    window.DrawText(
                        "The triangles do not intersect",
                        Color.Green,
                        225,
                        50
                    );
                }

                window.Refresh(60);
            }

            window.Close();
        }
    }
}
