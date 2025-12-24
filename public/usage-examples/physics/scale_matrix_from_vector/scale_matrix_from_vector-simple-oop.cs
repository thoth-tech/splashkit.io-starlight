using SplashKitSDK;

namespace MatrixScalingDemo
{
    public class Program
    {
        public static void Main()
        {
            // Define the scale factors
            Vector2D matrixScale = new Vector2D() { X = 2.0, Y = 1.0 }; // Scale width by 2, height unchanged

            // Create a scaling matrix using the scale factors
            Matrix2D scalingMatrix = SplashKit.ScaleMatrix(matrixScale);

            // Print the scaling matrix to the console
            SplashKit.WriteLine("Scaling Matrix:");
            SplashKit.WriteLine(SplashKit.MatrixToString(scalingMatrix));

            // Define a vector to demonstrate the scaling
            Vector2D originalVector = new Vector2D() { X = 100, Y = 50 };
            SplashKit.WriteLine($"Original Vector: {SplashKit.VectorToString(originalVector)}");

            // Apply the scaling matrix to the vector
            Vector2D scaledVector = SplashKit.MatrixMultiply(scalingMatrix, originalVector);
            SplashKit.WriteLine($"Scaled Vector (after applying scaling matrix): {SplashKit.VectorToString(scaledVector)}");
        }
    }
}
