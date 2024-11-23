using static SplashKitSDK.SplashKit;
using SplashKitSDK;

namespace TranslationExample
{
    public class Program
    {
        public static void Main()
        {
            // Define the translation point
            Vector2D matrixTranslation = new Vector2D() { X = 200, Y = 100 };

            // Create a translation matrix using the translation point
            Matrix2D myMatrix1 = TranslationMatrix(matrixTranslation);

            // Print the translation matrix to the console
            WriteLine("Translation Matrix:");
            WriteLine(MatrixToString(myMatrix1));

            // Define the original point
            Point2D originalPoint = new Point2D() { X = 50, Y = 50 };
            WriteLine("Original Point: " + PointToString(originalPoint));

            // Apply the translation matrix to the point
            Point2D translatedPoint = MatrixMultiply(myMatrix1, originalPoint);
            WriteLine("Translated Point (after applying translation matrix): " + PointToString(translatedPoint));
        }
    }
}
