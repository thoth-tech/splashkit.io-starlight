using SplashKitSDK;

namespace MatrixVectorTransformDemo
{
    public class Program
    {
        public static void Main()
        {
            // Define and populate the matrix
            Matrix2D myMatrix1 = new Matrix2D
            {
                Elements = new double[3, 3]
                {
                    { 1, 2, 3 },
                    { 0, 1, 4 },
                    { 5, 6, 0 }
                }
            };

            // Print the matrix
            SplashKit.WriteLine("Matrix:");
            SplashKit.WriteLine(SplashKit.MatrixToString(myMatrix1));

            // Define the vector
            Vector2D myVector1 = new Vector2D
            {
                X = 200,
                Y = 100
            };

            // Print the vector
            SplashKit.WriteLine("Original Vector:");
            SplashKit.WriteLine(SplashKit.VectorToString(myVector1));

            // Multiply the matrix by the vector
            Vector2D resultVector = SplashKit.MatrixMultiply(myMatrix1, myVector1);

            // Print the resulting vector
            SplashKit.WriteLine("Transformed Vector:");
            SplashKit.WriteLine(SplashKit.VectorToString(resultVector));
        }
    }
}
