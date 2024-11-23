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
            Matrix2D translationMatrix = TranslationMatrix(translationX, translationY);

            // Print the translation matrix to the console
            WriteLine("Translation Matrix:");
            WriteLine(MatrixToString(translationMatrix));

            // Define the original point
            Point2D originalPoint = new Point2D() { X = 50, Y = 50 };
            WriteLine("Original Point: " + PointToString(originalPoint));

            // Apply the translation to the point
            Point2D translatedPoint = MatrixMultiply(translationMatrix, originalPoint);
            WriteLine("Translated Point: " + PointToString(translatedPoint));
        }
    }
}
