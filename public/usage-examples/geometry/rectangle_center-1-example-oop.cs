using SplashKitSDK;

namespace RectangleCenterExample
{
    public class Program
    {
        public static void Main()
        {
            // Declare a variable with camelCase
            string exampleMessage = "this is an example of camelCase";

            // Open a window for drawing
            SplashKit.OpenWindow("Spotlight on Center", 600, 400);

            // Create a rectangle
            Rectangle exampleRectangle = SplashKit.RectangleFrom(100, 100, 200, 150);

            // Get the center of the rectangle
            Point2D centerPoint = SplashKit.RectangleCenter(exampleRectangle);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen(Color.White);

                // Draw the rectangle
                SplashKit.DrawRectangle(
                    Color.Blue,
                    exampleRectangle.X,
                    exampleRectangle.Y,
                    exampleRectangle.Width,
                    exampleRectangle.Height
                );

                // Draw a circle at the center
                SplashKit.FillCircle(Color.Red, centerPoint, 5);

                // Label the center
                SplashKit.DrawText("Center", Color.Black, "Arial", 12, centerPoint.X + 8, centerPoint.Y - 6);

                SplashKit.RefreshScreen();
            }

            SplashKit.CloseWindow("Spotlight on Center");
        }
    }
}
