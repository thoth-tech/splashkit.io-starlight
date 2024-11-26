using SplashKitSDK;

namespace ScaleMatrixDemo
{
    public class Program
    {
        public static void Main()
        {
            // Define the scale factors
            Vector2D matrixScale = new Vector2D() { X = 200, Y = 100 };

            // Create a scaling matrix using the scale factors
            Matrix2D myMatrix1 = SplashKit.ScaleMatrix(matrixScale);

            // Print the scaling matrix to the console
            SplashKit.WriteLine(SplashKit.MatrixToString(myMatrix1));
        }
    }
}
