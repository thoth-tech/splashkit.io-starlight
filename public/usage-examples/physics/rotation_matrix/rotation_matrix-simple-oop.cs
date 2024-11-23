using static SplashKitSDK.SplashKit;
using SplashKitSDK;

namespace RotationMatrixDemo
{
    public class Program
    {
        public static void Main()
        {
            // Create a rotation matrix for 90 degrees
            Matrix2D myMatrix1 = RotationMatrix(90);

            // Print the rotation matrix to the console
            WriteLine(MatrixToString(myMatrix1));
        }
    }
}
