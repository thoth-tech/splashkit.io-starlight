using static SplashKitSDK.SplashKit;
using SplashKitSDK;

namespace TranslationMatrixDemo
{
    public class Program
    {
        public static void Main()
        {
            // Define the translation values
            double translationX = 200;
            double translationY = 100;

            // Create a translation matrix using the translation values
            Matrix2D myMatrix1 = TranslationMatrix(translationX, translationY);

            // Print the translation matrix to the console
            WriteLine(MatrixToString(myMatrix1));
        }
    }
}
