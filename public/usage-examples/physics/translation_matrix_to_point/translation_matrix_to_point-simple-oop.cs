using SplashKitSDK;

namespace TranslationVectorExample
{
    public class Program
    {
        public static void Main()
        {
            // Define the translation vector
            Point2D matrixTranslation = new Point2D() { X = 200, Y = 100 };

            // Create a translation matrix using the translation vector
            Matrix2D myMatrix1 = SplashKit.TranslationMatrix(matrixTranslation);

            // Print the translation matrix to the console
            SplashKit.WriteLine("Translation Matrix:");
            SplashKit.WriteLine(SplashKit.MatrixToString(myMatrix1));

            // Define an original point
            Point2D originalPoint = new Point2D() { X = 50, Y = 50 };
            SplashKit.WriteLine("Original Point: " + SplashKit.PointToString(originalPoint));

            // Apply the translation matrix to the point
            Point2D translatedPoint = SplashKit.MatrixMultiply(myMatrix1, originalPoint);
            SplashKit.WriteLine("Translated Point (after applying translation matrix): " + SplashKit.PointToString(translatedPoint));
        }
    }
}
