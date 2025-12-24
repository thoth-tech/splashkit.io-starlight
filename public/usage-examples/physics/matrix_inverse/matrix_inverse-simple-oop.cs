using SplashKitSDK;

namespace MatrixInverseDemo
{
    public class Program
    {
        public static void Main()
        {
            // Define a transformation matrix (scaling)
            Matrix2D scalingMatrix = SplashKit.ScaleMatrix(2.0);

            // Print the scaling matrix
            SplashKit.WriteLine("Scaling Matrix:");
            SplashKit.WriteLine(SplashKit.MatrixToString(scalingMatrix));

            // Calculate the inverse of the scaling matrix
            Matrix2D inverseMatrix = SplashKit.MatrixInverse(scalingMatrix);

            // Print the inverse matrix
            SplashKit.WriteLine("Inverse Matrix:");
            SplashKit.WriteLine(SplashKit.MatrixToString(inverseMatrix));

            // Define a point
            Point2D originalPoint = new Point2D { X = 100, Y = 100 };
            SplashKit.WriteLine($"Original Point: {SplashKit.PointToString(originalPoint)}");

            // Transform the point
            Point2D transformedPoint = SplashKit.MatrixMultiply(scalingMatrix, originalPoint);
            SplashKit.WriteLine($"Transformed Point: {SplashKit.PointToString(transformedPoint)}");

            // Apply the inverse transformation to recover the original point
            Point2D recoveredPoint = SplashKit.MatrixMultiply(inverseMatrix, transformedPoint);
            SplashKit.WriteLine($"Recovered Point: {SplashKit.PointToString(recoveredPoint)}");
        }
    }
}
