using static SplashKitSDK.SplashKit;
using SplashKitSDK;

// Define the scaling factors
Point2D matrixScale = new Point2D() { X = 200, Y = 100 };

// Define the translation
Point2D matrixTranslation = new Point2D() { X = 50, Y = 50 };

// Define the rotation angle
double rotation = 90;

// Create a matrix combining scaling, rotation, and translation
Matrix2D myMatrix1 = ScaleRotateTranslateMatrix(matrixScale, rotation, matrixTranslation);

// Print the resulting matrix to the console
WriteLine(MatrixToString(myMatrix1));
