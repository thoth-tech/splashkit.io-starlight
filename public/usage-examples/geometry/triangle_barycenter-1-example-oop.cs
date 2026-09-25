using SplashKitSDK;

namespace TriangleBarycenterExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Triangle Barycenter", 800, 600);

            Triangle tri = SplashKit.TriangleFrom(
                200, 450,
                400, 120,
                620, 450
            );

            Point2D barycenter = SplashKit.TriangleBarycenter(tri);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                SplashKit.ClearScreen(Color.White);

                SplashKit.FillTriangle(Color.LightBlue, tri);
                SplashKit.DrawTriangle(Color.Black, tri);

                SplashKit.FillCircle(
                    Color.Red,
                    barycenter.X,
                    barycenter.Y,
                    8
                );

                SplashKit.DrawText(
                    "Triangle Barycenter",
                    Color.Black,
                    20,
                    20
                );

                SplashKit.DrawText(
                    "The red point shows the barycenter of the triangle.",
                    Color.Black,
                    20,
                    50
                );

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}