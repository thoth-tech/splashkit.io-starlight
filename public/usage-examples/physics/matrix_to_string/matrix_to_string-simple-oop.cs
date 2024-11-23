using static SplashKitSDK.SplashKit;
using SplashKitSDK;

namespace MatrixToStringDemo
{
    public class Program
    {
        public static void Main()
        {
            // Create an identity matrix
            Matrix2D myMatrix1 = IdentityMatrix();

            // Print the identity matrix to the console
            WriteLine(MatrixToString(myMatrix1));
        }
    }
}
