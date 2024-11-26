using SplashKitSDK;

namespace TransformationMatrixVisualization
{
    public class Program
    {
        public static void Main()
        {
            // Open a window for visualization
            SplashKit.OpenWindow("Transformation Matrix Visualization", 400, 400);
            SplashKit.ClearScreen(SplashKit.ColorWhite());

            // Define the scaling factors
            Point2D matrixScale = new Point2D() { X = 1.5, Y = 1.2 };

            // Define the translation (shift by a small amount)
            Point2D matrixTranslation = new Point2D() { X = 20, Y = -30 };

            // Define the rotation angle
            double rotation = 45;

            // Create a matrix combining scaling, rotation, and translation
            Matrix2D transformationMatrix = SplashKit.ScaleRotateTranslateMatrix(matrixScale, rotation, matrixTranslation);

            // Define the original triangle points (centered and larger)
            Triangle originalTriangle = new Triangle()
            {
                Points = new[]
                {
                    new Point2D() { X = 200, Y = 150 }, // Top point
                    new Point2D() { X = 150, Y = 250 }, // Bottom-left point
                    new Point2D() { X = 250, Y = 250 }  // Bottom-right point
                }
            };

            // Draw the original triangle
            SplashKit.FillTriangle(SplashKit.ColorBlue(), originalTriangle);
            SplashKit.WriteLine("Original (Blue) Triangle Points:");
            foreach (var point in originalTriangle.Points)
            {
                SplashKit.WriteLine(SplashKit.PointToString(point));
            }

            // Transform the triangle using the transformation matrix
            SplashKit.ApplyMatrix(transformationMatrix, ref originalTriangle);

            // Draw the transformed triangle
            SplashKit.FillTriangle(SplashKit.ColorRed(), originalTriangle);
            SplashKit.WriteLine("Transformed (Red) Triangle Points:");
            foreach (var point in originalTriangle.Points)
            {
                SplashKit.WriteLine(SplashKit.PointToString(point));
            }

            // Refresh the screen
            SplashKit.RefreshScreen();
            SplashKit.Delay(5000);

            SplashKit.CloseAllWindows();
        }
    }
}
