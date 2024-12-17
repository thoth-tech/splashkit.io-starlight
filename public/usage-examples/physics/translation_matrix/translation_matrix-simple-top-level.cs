using static SplashKitSDK.SplashKit;
using SplashKitSDK;

// Define the translation values
double translationX = 200;
double translationY = 100;

// Create a translation matrix using the translation values
Matrix2D myMatrix1 = TranslationMatrix(translationX, translationY);

// Print the translation matrix to the console
WriteLine("Translation Matrix:");
WriteLine(MatrixToString(myMatrix1));

// Define the original point
Point2D originalPoint = new Point2D() { X = 50, Y = 50 };
WriteLine("Original Point: " + PointToString(originalPoint));

// Apply the translation to the point
Point2D translatedPoint = MatrixMultiply(myMatrix1, originalPoint);
WriteLine("Translated Point: " + PointToString(translatedPoint));
