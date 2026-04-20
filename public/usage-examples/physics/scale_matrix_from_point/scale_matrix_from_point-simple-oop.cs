using SplashKitSDK;

namespace MatrixScalingDemo
{
    public class Program
    {
        public static void Main()
        {
            // Define the scale factors
            Point2D matrixScale = new Point2D() { X = 2.0, Y = 1.0 }; // Scale width by 2, height unchanged

            // Create a scaling matrix using the scale factors
            Matrix2D scalingMatrix = SplashKit.ScaleMatrix(matrixScale);

            // Print the scaling matrix to the console
            SplashKit.WriteLine("Scaling Matrix:");
            SplashKit.WriteLine(SplashKit.MatrixToString(scalingMatrix));

            // Define a point to apply the scaling matrix
            Point2D originalPoint = new Point2D() { X = 100, Y = 50 };
            SplashKit.WriteLine($"Original Point: {SplashKit.PointToString(originalPoint)}");

            // Apply the scaling matrix to the point
            Point2D scaledPoint = SplashKit.MatrixMultiply(scalingMatrix, originalPoint);
            SplashKit.WriteLine($"Scaled Point (after applying scaling matrix): {SplashKit.PointToString(scaledPoint)}");
        }
    }
}
