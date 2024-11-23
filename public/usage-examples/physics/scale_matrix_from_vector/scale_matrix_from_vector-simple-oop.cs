using static SplashKitSDK.SplashKit;
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
            Matrix2D scalingMatrix = ScaleMatrix(matrixScale);

            // Print the scaling matrix to the console
            WriteLine("Scaling Matrix:");
            WriteLine(MatrixToString(scalingMatrix));

            // Define a vector to demonstrate the scaling
            Vector2D originalVector = new Vector2D() { X = 100, Y = 50 };
            WriteLine($"Original Vector: {VectorToString(originalVector)}");

            // Apply the scaling matrix to the vector
            Vector2D scaledVector = MatrixMultiply(scalingMatrix, originalVector);
            WriteLine($"Scaled Vector (after applying scaling matrix): {VectorToString(scaledVector)}");
        }
    }
}
