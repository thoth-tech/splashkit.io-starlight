using SplashKitSDK;
using static SplashKitSDK.SplashKit;

namespace RotationMatrixDemo
{
    public class Program
    {
        public static void Main()
        {
            // Create a rotation matrix for 45 degrees
            Matrix2D rotationMatrix45 = RotationMatrix(45);

            // Print the rotation matrix to the console
            WriteLine("Rotation Matrix (45 degrees):");
            WriteLine(MatrixToString(rotationMatrix45));

            // Define a point
            Point2D originalPoint = new Point2D() { X = 1, Y = 0 }; // A point on the x-axis
            WriteLine("Original Point:");
            WriteLine(PointToString(originalPoint));

            // Apply the rotation matrix to the point
            Point2D rotatedPoint = MatrixMultiply(rotationMatrix45, originalPoint);
            WriteLine("Rotated Point (after 45-degree rotation):");
            WriteLine(PointToString(rotatedPoint));
        }
    }
}
