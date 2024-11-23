using static SplashKitSDK.SplashKit;
using SplashKitSDK;

// Define the scale factors
Vector2D matrixScale = new Vector2D() { X = 200, Y = 100 };

// Create a scaling matrix using the scale factors
Matrix2D myMatrix1 = ScaleMatrix(matrixScale);

// Print the scaling matrix to the console
WriteLine(MatrixToString(myMatrix1));
