using SplashKitSDK;

namespace TriangleToStringExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Triangle To String", 800, 600);

            // Create a triangle to describe
            Triangle demoTriangle = new Triangle()
            {
                Points = new Point2D[]
                {
                    SplashKit.PointAt(300, 200),
                    SplashKit.PointAt(500, 200),
                    SplashKit.PointAt(400, 400)
                }
            };

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // Convert the triangle into a text description
                string triangleText = SplashKit.TriangleToString(demoTriangle);

                SplashKit.ClearScreen(Color.White);

                // Draw the triangle
                SplashKit.DrawTriangle(Color.Blue, demoTriangle);

                // Display the generated text
                SplashKit.DrawText("Triangle description:", Color.Black, 20, 20);
                SplashKit.DrawText(triangleText, Color.Black, 20, 50);

                SplashKit.RefreshScreen(60);
            }
        }
    }
}