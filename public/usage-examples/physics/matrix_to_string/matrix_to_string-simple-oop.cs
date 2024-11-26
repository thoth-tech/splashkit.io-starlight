using SplashKitSDK;

namespace MatrixToStringDemo
{
    public class Program
    {
        public static void Main()
        {
            // Create an identity matrix
            Matrix2D myMatrix1 = SplashKit.IdentityMatrix();

            // Print the identity matrix to the console
            SplashKit.WriteLine(SplashKit.MatrixToString(myMatrix1));
        }
    }
}
