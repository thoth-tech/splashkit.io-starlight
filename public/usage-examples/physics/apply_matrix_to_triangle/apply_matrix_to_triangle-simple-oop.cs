using SplashKitSDK;

namespace ApplyMatrixToTriangle
{
    public class Program
    {
        public static void Main()
        {
            // Open the window
            SplashKit.OpenWindow("Apply Matrix to Triangle", 300, 300);

            // Clear the screen
            SplashKit.ClearScreen(SplashKit.ColorWhite());

            // Define the triangle points
            Triangle testTriangle1 = new Triangle();
            testTriangle1.Points = new Point2D[3];
            testTriangle1.Points[0] = new Point2D() { X = 150, Y = 150 };
            testTriangle1.Points[1] = new Point2D() { X = 80, Y = 220 };
            testTriangle1.Points[2] = new Point2D() { X = 220, Y = 220 };

            // Define the transformation matrix (scaling + translation)
            Matrix2D scalingMatrix = SplashKit.ScaleMatrix(0.5);
            Matrix2D translationMatrix = SplashKit.TranslationMatrix(-25, 50);
            Matrix2D combinedMatrix = SplashKit.MatrixMultiply(scalingMatrix, translationMatrix);

            // Draw the initial triangle
            SplashKit.FillTriangle(SplashKit.ColorBlack(), testTriangle1);
            SplashKit.WriteLine("Triangle points before matrix application:");
            foreach (Point2D point in testTriangle1.Points)
                SplashKit.WriteLine(SplashKit.PointToString(point));

            // Apply the matrix to the triangle
            SplashKit.ApplyMatrix(combinedMatrix, ref testTriangle1);

            // Draw the transformed triangle
            SplashKit.FillTriangle(SplashKit.ColorRed(), testTriangle1);
            SplashKit.WriteLine("Triangle points after matrix application:");
            foreach (Point2D point in testTriangle1.Points)
                SplashKit.WriteLine(SplashKit.PointToString(point));

            // Refresh the screen and wait
            SplashKit.RefreshScreen();
            SplashKit.Delay(4000);

            // Close all windows
            SplashKit.CloseAllWindows();
        }
    }
}
