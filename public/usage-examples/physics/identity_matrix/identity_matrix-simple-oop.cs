using SplashKitSDK;

namespace MatrixDemo
{
    public class Program
    {
        public static void Main()
        {
            // Create an identity matrix
            Matrix2D myMatrix1 = SplashKit.IdentityMatrix();

            // Print the matrix to the console
            SplashKit.WriteLine(SplashKit.MatrixToString(myMatrix1));
        }
    }
}
