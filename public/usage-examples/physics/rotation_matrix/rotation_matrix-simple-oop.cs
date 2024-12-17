using SplashKitSDK;

namespace RotationMatrixDemo
{
    public class Program
    {
        public static void Main()
        {
            // Create a rotation matrix for 45 degrees
            Matrix2D rotationMatrix45 = SplashKit.RotationMatrix(45);

            // Print the rotation matrix to the console
            SplashKit.WriteLine("Rotation Matrix (45 degrees):");
            SplashKit.WriteLine(SplashKit.MatrixToString(rotationMatrix45));

            // Define a point
            Point2D originalPoint = new Point2D() { X = 1, Y = 0 }; // A point on the x-axis
            SplashKit.WriteLine("Original Point:");
            SplashKit.WriteLine(SplashKit.PointToString(originalPoint));

            // Apply the rotation matrix to the point
            Point2D rotatedPoint = SplashKit.MatrixMultiply(rotationMatrix45, originalPoint);
            SplashKit.WriteLine("Rotated Point (after 45-degree rotation):");
            SplashKit.WriteLine(SplashKit.PointToString(rotatedPoint));
        }
    }
}
