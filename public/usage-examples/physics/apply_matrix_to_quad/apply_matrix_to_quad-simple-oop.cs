using static SplashKitSDK.SplashKit;
using SplashKitSDK;

namespace ApplyMatrixDemo
{
    public class Program
    {
        public static void Main()
        {
            // Open the window
            OpenWindow("Apply Matrix", 300, 300);

            // Clear the screen
            ClearScreen(Color.White);

            // Define the quad points
            Quad testRectangle1 = new Quad();
            Point2D topLeft = new Point2D() { X = 140, Y = 140 };
            Point2D topRight = new Point2D() { X = 160, Y = 140 };
            Point2D bottomLeft = new Point2D() { X = 140, Y = 160 };
            Point2D bottomRight = new Point2D() { X = 160, Y = 160 };

            testRectangle1.Points[0] = topLeft;
            testRectangle1.Points[1] = topRight;
            testRectangle1.Points[2] = bottomLeft;
            testRectangle1.Points[3] = bottomRight;

            // Create and populate the matrix
            Matrix2D myMatrix1 = new Matrix2D();
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    myMatrix1.Elements[i, j] = 0.5;

            // Draw the initial quad
            DrawQuad(Color.Black, testRectangle1);
            WriteLine("Quad points before matrix application:");
            foreach (Point2D point in testRectangle1.Points)
                WriteLine(PointToString(point));

            // Apply the matrix to the quad
            ApplyMatrix(myMatrix1, testRectangle1);

            // Draw the transformed quad
            DrawQuad(Color.Red, testRectangle1);
            WriteLine("Quad points after matrix application:");
            foreach (Point2D point in testRectangle1.Points)
                WriteLine(PointToString(point));

            // Refresh the screen and wait
            RefreshScreen();
            Delay(4000);

            // Close all windows
            CloseAllWindows();
        }
    }
}
