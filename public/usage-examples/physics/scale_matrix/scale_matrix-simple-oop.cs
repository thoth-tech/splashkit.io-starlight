using SplashKitSDK;

namespace ScalingMatrixDemo
{
    public class Program
    {
        public static void Main()
        {
            // Define the uniform scaling factor
            double scalingFactor = 2.0;

            // Create a scaling matrix using the uniform scaling factor
            Matrix2D scalingMatrix = SplashKit.ScaleMatrix(scalingFactor);

            // Print the scaling matrix to the console
            SplashKit.WriteLine("Scaling Matrix (Uniform Scaling by factor of 2):");
            SplashKit.WriteLine(SplashKit.MatrixToString(scalingMatrix));

            // Define a point
            Point2D originalPoint = new Point2D() { X = 100, Y = 50 };
            SplashKit.WriteLine("Original Point:");
            SplashKit.WriteLine(SplashKit.PointToString(originalPoint));

            // Apply the scaling matrix to the point
            Point2D scaledPoint = SplashKit.MatrixMultiply(scalingMatrix, originalPoint);
            SplashKit.WriteLine("Scaled Point (after scaling by factor of 2):");
            SplashKit.WriteLine(SplashKit.PointToString(scaledPoint));
        }
    }
}
