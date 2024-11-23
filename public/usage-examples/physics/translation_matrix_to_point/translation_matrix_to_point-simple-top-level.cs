using static SplashKitSDK.SplashKit;
using SplashKitSDK;

// Define the translation vector
Vector2D matrixTranslation = new Vector2D() { X = 200, Y = 100 };

// Create a translation matrix using the translation vector
Matrix2D myMatrix1 = TranslationMatrix(matrixTranslation);

// Print the translation matrix to the console
WriteLine(MatrixToString(myMatrix1));
