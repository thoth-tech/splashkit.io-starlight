using static SplashKitSDK.SplashKit;
using SplashKitSDK;

namespace VectorVisualisationDemo
{
    public class Program
    {
        public static void Main()
        {
            // Open the window
            OpenWindow("Vector Visualisations", 300, 300);

            // Define rectangles
            Rectangle testRectangle1 = new Rectangle() { X = 50, Y = 200, Width = 50, Height = 50 };
            Rectangle testRectangle2 = new Rectangle() { X = 200, Y = 200, Width = 50, Height = 50 };
            Rectangle testRectangle3 = new Rectangle() { X = 200, Y = 50, Width = 50, Height = 50 };

            // Define origin point
            Point2D origin = new Point2D() { X = 0, Y = 0 };

            // Create vectors from origin to rectangles
            Vector2D myVector1 = VectorFromPointToRect(origin, testRectangle1);
            Vector2D myVector2 = VectorFromPointToRect(origin, testRectangle2);
            Vector2D myVector3 = VectorFromPointToRect(origin, testRectangle3);

            // Clear the screen
            ClearScreen();

            // Draw rectangles
            FillRectangle(ColorRed, testRectangle1);
            FillRectangle(ColorBlue, testRectangle2);
            FillRectangle(ColorPurple, testRectangle3);

            // Draw lines representing vectors
            DrawLine(ColorBlack, LineFrom(myVector1));
            DrawLine(ColorOrange, LineFrom(myVector2));
            DrawLine(ColorBrown, LineFrom(myVector3));

            // Refresh the screen
            RefreshScreen();

            // Wait and close the window
            Delay(4000);
            CloseAllWindows();
        }
    }
}
