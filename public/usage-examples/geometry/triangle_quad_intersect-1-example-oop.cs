using SplashKitSDK;

namespace TriangleQuadIntersectExample
{
    public class Program
    {
        public static void Main()
        {
            Window window = new Window("Triangle Quad Intersect", 800, 600);

            // Create a fixed quad
            Quad targetQuad = SplashKit.QuadFrom(
                450, 180,
                650, 180,
                450, 380,
                650, 380
            );

            while (!window.CloseRequested)
            {
                SplashKit.ProcessEvents();

                // Get current mouse position
                Point2D mousePoint = SplashKit.MousePosition();
                double mx = mousePoint.X;
                double my = mousePoint.Y;

                // Create a triangle that follows the mouse
                Triangle movingTriangle = SplashKit.TriangleFrom(
                    mx, my - 60,
                    mx - 60, my + 50,
                    mx + 60, my + 50
                );

                // Check whether the triangle intersects the quad
                bool intersects = SplashKit.TriangleQuadIntersect(
                    movingTriangle,
                    targetQuad
                );

                window.Clear(Color.White);

                SplashKit.FillQuad(Color.LightGray, targetQuad);
                SplashKit.DrawQuad(Color.Black, targetQuad);

                if (intersects)
                {
                    SplashKit.FillTriangle(Color.Red, movingTriangle);

                    SplashKit.DrawText(
                        "Triangle intersects the quad!",
                        Color.Red,
                        20,
                        20
                    );
                }
                else
                {
                    SplashKit.FillTriangle(Color.Blue, movingTriangle);

                    SplashKit.DrawText(
                        "Move the triangle into the quad",
                        Color.Black,
                        20,
                        20
                    );
                }

                SplashKit.DrawTriangle(Color.Black, movingTriangle);

                window.Refresh(60);
            }

            window.Close();
        }
    }
}
