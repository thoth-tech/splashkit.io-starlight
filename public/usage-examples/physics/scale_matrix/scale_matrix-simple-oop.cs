using static SplashKitSDK.SplashKit;
using SplashKitSDK;

namespace ScaleMatrixDemo
{
    public class Program
    {
        public static void Main()
        {
            // Define the uniform scaling factor
            double matrixScale = 200;

            // Create a scaling matrix using the uniform scaling factor
            Matrix2D myMatrix1 = ScaleMatrix(matrixScale);

            // Print the scaling matrix to the console
            WriteLine(MatrixToString(myMatrix1));
        }
    }
}
