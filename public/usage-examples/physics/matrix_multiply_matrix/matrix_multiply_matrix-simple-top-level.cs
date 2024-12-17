using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Define and populate the first matrix
Matrix2D myMatrix1 = new Matrix2D
{
    Elements = new double[3, 3]
    {
        { 1, 2, 3 },
        { 0, 1, 4 },
        { 5, 6, 0 }
    }
};

// Define and populate the second matrix
Matrix2D myMatrix2 = new Matrix2D
{
    Elements = new double[3, 3]
    {
        { 7, 8, 9 },
        { 1, 0, 2 },
        { 3, 4, 5 }
    }
};

// Multiply the two matrices
Matrix2D resultMatrix = MatrixMultiply(myMatrix1, myMatrix2);

// Print the original matrices and the result
WriteLine("Matrix 1:");
WriteLine(MatrixToString(myMatrix1));

WriteLine("Matrix 2:");
WriteLine(MatrixToString(myMatrix2));

WriteLine("Resulting Matrix (Matrix 1 x Matrix 2):");
WriteLine(MatrixToString(resultMatrix));
