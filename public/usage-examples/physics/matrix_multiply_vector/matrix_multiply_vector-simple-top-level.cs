using static SplashKitSDK.SplashKit;
using SplashKitSDK;

// Define and populate the first matrix
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

// Define the second matrix as an identity matrix
Matrix2D myMatrix2 = IdentityMatrix();

// Multiply the two matrices
Matrix2D resultMatrix = MatrixMultiply(myMatrix1, myMatrix2);

// Print the matrices
WriteLine(MatrixToString(myMatrix1));
WriteLine(MatrixToString(myMatrix2));
WriteLine(MatrixToString(resultMatrix));
