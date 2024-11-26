using SplashKitSDK;

namespace ApplyMatrixDemo
{
    public class Program
    {
        public static void Main()
        {
            // Open the window
            SplashKit.OpenWindow("Apply Matrix", 400, 400);

            // Clear the screen
            SplashKit.ClearScreen(SplashKit.ColorWhite());

            // Define the quad points
            Quad testRectangle1 = new Quad();
            testRectangle1.Points = new Point2D[4];
            testRectangle1.Points[0] = new Point2D() { X = 150, Y = 150 };
            testRectangle1.Points[1] = new Point2D() { X = 250, Y = 150 };
            testRectangle1.Points[2] = new Point2D() { X = 150, Y = 250 };
            testRectangle1.Points[3] = new Point2D() { X = 250, Y = 250 };

            // Define the transformation matrix (scaling + translation)
            Matrix2D scalingMatrix = SplashKit.ScaleMatrix(0.5);
            Matrix2D translationMatrix = SplashKit.TranslationMatrix(50, 50);
            Matrix2D combinedMatrix = SplashKit.MatrixMultiply(scalingMatrix, translationMatrix);

            // Draw the initial quad
            SplashKit.FillQuad(SplashKit.ColorBlack(), testRectangle1);
            SplashKit.WriteLine("Quad points before matrix application:");
            for (int i = 0; i < 4; i++)
                SplashKit.WriteLine(SplashKit.PointToString(testRectangle1.Points[i]));

            // Apply the matrix to the quad
            SplashKit.ApplyMatrix(combinedMatrix, ref testRectangle1);

            // Draw the transformed quad
            SplashKit.FillQuad(SplashKit.ColorRed(), testRectangle1);
            SplashKit.WriteLine("Quad points after matrix application:");
            for (int i = 0; i < 4; i++)
                SplashKit.WriteLine(SplashKit.PointToString(testRectangle1.Points[i]));

            // Refresh the screen and wait
            SplashKit.RefreshScreen();
            SplashKit.Delay(4000);

            // Close all windows
            SplashKit.CloseAllWindows();
        }
    }
}
