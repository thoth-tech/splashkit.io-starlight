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
            Matrix2D myMatrix1 = SplashKit.TranslationMatrix(translationX, translationY);

            // Print the translation matrix to the console
            SplashKit.WriteLine("Translation Matrix:");
            SplashKit.WriteLine(SplashKit.MatrixToString(myMatrix1));

            // Define the original point
            Point2D originalPoint = new Point2D() { X = 50, Y = 50 };
            SplashKit.WriteLine("Original Point: " + SplashKit.PointToString(originalPoint));

            // Apply the translation to the point
            Point2D translatedPoint = SplashKit.MatrixMultiply(myMatrix1, originalPoint);
            SplashKit.WriteLine("Translated Point: " + SplashKit.PointToString(translatedPoint));
        }
    }
}
