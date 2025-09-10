using SplashKitSDK;

namespace MatrixMultiplicationDemo
{
    public class Program
    {
        public static void Main()
        {
            // Define and populate the first matrix
            Matrix2D myMatrix1 = new Matrix2D
            {
                Elements = new double[3, 3]
                {
                    { 1, 2, 3 },
                    { 0, 1, 4 },
                    { 5, 6, 0 }
                }
            };

            // Define and populate the second matrix
            Matrix2D myMatrix2 = new Matrix2D
            {
                Elements = new double[3, 3]
                {
                    { 7, 8, 9 },
                    { 1, 0, 2 },
                    { 3, 4, 5 }
                }
            };

            // Multiply the two matrices
            Matrix2D resultMatrix = SplashKit.MatrixMultiply(myMatrix1, myMatrix2);

            // Print the original matrices and the result
            SplashKit.WriteLine("Matrix 1:");
            SplashKit.WriteLine(SplashKit.MatrixToString(myMatrix1));

            SplashKit.WriteLine("Matrix 2:");
            SplashKit.WriteLine(SplashKit.MatrixToString(myMatrix2));

            SplashKit.WriteLine("Resulting Matrix (Matrix 1 x Matrix 2):");
            SplashKit.WriteLine(SplashKit.MatrixToString(resultMatrix));
        }
    }
}
