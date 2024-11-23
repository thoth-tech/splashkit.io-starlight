using static SplashKitSDK.SplashKit;
using SplashKitSDK;

// Define and populate the matrix
Matrix2D myMatrix1 = new Matrix2D();
myMatrix1.Elements[0, 0] = 1;
myMatrix1.Elements[0, 1] = 2;
myMatrix1.Elements[0, 2] = 3;

myMatrix1.Elements[1, 0] = 0;
myMatrix1.Elements[1, 1] = 1;
myMatrix1.Elements[1, 2] = 4;

myMatrix1.Elements[2, 0] = 5;
myMatrix1.Elements[2, 1] = 6;
myMatrix1.Elements[2, 2] = 0;

// Define the point
Point2D myPoint1 = new Point2D() { X = 200, Y = 100 };

// Multiply the matrix by the point
Point2D resultPoint = MatrixMultiply(myMatrix1, myPoint1);

// Print the matrix and points
WriteLine(MatrixToString(myMatrix1));
WriteLine(PointToString(myPoint1));
WriteLine(PointToString(resultPoint));
