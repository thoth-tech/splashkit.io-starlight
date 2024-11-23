using static SplashKitSDK.SplashKit;
using SplashKitSDK;

// Define the translation vector
Point2D matrixTranslation = new Point2D() { X = 200, Y = 100 };

// Create a translation matrix using the translation vector
Matrix2D myMatrix1 = TranslationMatrix(matrixTranslation);

// Print the translation matrix to the console
WriteLine("Translation Matrix:");
WriteLine(MatrixToString(myMatrix1));

// Define an original point
Point2D originalPoint = new Point2D() { X = 50, Y = 50 };
WriteLine("Original Point: " + PointToString(originalPoint));

// Apply the translation matrix to the point
Point2D translatedPoint = MatrixMultiply(myMatrix1, originalPoint);
WriteLine("Translated Point (after applying translation matrix): " + PointToString(translatedPoint));
