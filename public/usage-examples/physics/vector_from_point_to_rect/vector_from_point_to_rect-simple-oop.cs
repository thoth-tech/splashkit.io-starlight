using SplashKitSDK;

namespace VectorVisualisationDemo
{
    public class Program
    {
        public static void Main()
        {
            // Open the window
            SplashKit.OpenWindow("Vector Visualisations", 300, 300);

            // Define rectangles
            Rectangle testRectangle1 = new Rectangle() { X = 50, Y = 200, Width = 50, Height = 50 };
            Rectangle testRectangle2 = new Rectangle() { X = 200, Y = 200, Width = 50, Height = 50 };
            Rectangle testRectangle3 = new Rectangle() { X = 200, Y = 50, Width = 50, Height = 50 };

            // Define origin point
            Point2D origin = new Point2D() { X = 0, Y = 0 };

            // Create vectors from origin to rectangles
            Vector2D myVector1 = SplashKit.VectorFromPointToRect(origin, testRectangle1);
            Vector2D myVector2 = SplashKit.VectorFromPointToRect(origin, testRectangle2);
            Vector2D myVector3 = SplashKit.VectorFromPointToRect(origin, testRectangle3);

            // Clear the screen
            SplashKit.ClearScreen();

            // Draw rectangles
            SplashKit.FillRectangle(SplashKit.ColorRed(), testRectangle1);
            SplashKit.FillRectangle(SplashKit.ColorBlue(), testRectangle2);
            SplashKit.FillRectangle(SplashKit.ColorPurple(), testRectangle3);

            // Draw lines representing vectors
            SplashKit.DrawLine(SplashKit.ColorBlack(), SplashKit.LineFrom(myVector1));
            SplashKit.DrawLine(SplashKit.ColorOrange(), SplashKit.LineFrom(myVector2));
            SplashKit.DrawLine(SplashKit.ColorBrown(), SplashKit.LineFrom(myVector3));

            // Refresh the screen
            SplashKit.RefreshScreen();

            // Wait and close the window
            SplashKit.Delay(4000);
            SplashKit.CloseAllWindows();
        }
    }
}
