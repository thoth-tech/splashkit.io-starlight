using static SplashKitSDK.SplashKit;
using SplashKitSDK;

// Define the translation point
Point2D matrixTranslation = new Point2D() { X = 200, Y = 100 };

// Create a translation matrix using the translation point
Matrix2D myMatrix1 = TranslationMatrix(matrixTranslation);

// Print the translation matrix to the console
WriteLine(MatrixToString(myMatrix1));
