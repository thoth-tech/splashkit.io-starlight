using SplashKitSDK;

namespace MatrixPointMultiplicationDemo
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

            // Define the point
            Point2D myPoint1 = new Point2D { X = 200, Y = 100 };

            // Multiply the matrix by the point
            Point2D resultPoint = SplashKit.MatrixMultiply(myMatrix1, myPoint1);

            // Print the matrix and points
            SplashKit.WriteLine("Matrix:");
            SplashKit.WriteLine(SplashKit.MatrixToString(myMatrix1));

            SplashKit.WriteLine("Original Point:");
            SplashKit.WriteLine(SplashKit.PointToString(myPoint1));

            SplashKit.WriteLine("Transformed Point:");
            SplashKit.WriteLine(SplashKit.PointToString(resultPoint));
        }
    }
}
