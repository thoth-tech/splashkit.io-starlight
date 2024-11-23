using static SplashKitSDK.SplashKit;
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
            Matrix2D scalingMatrix = ScaleMatrix(scalingFactor);

            // Print the scaling matrix to the console
            WriteLine("Scaling Matrix (Uniform Scaling by factor of 2):");
            WriteLine(MatrixToString(scalingMatrix));

            // Define a point
            Point2D originalPoint = new Point2D() { X = 100, Y = 50 };
            WriteLine("Original Point:");
            WriteLine(PointToString(originalPoint));

            // Apply the scaling matrix to the point
            Point2D scaledPoint = MatrixMultiply(scalingMatrix, originalPoint);
            WriteLine("Scaled Point (after scaling by factor of 2):");
            WriteLine(PointToString(scaledPoint));
        }
    }
}
