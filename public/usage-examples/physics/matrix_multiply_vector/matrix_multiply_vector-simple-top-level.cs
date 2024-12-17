using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Define and populate the matrix
Matrix2D myMatrix1 = new Matrix2D
{
    Elements = new double[3, 3]
    {
        { 1, 2, 3 },
        { 0, 1, 4 },
        { 5, 6, 0 }
    }
};

// Print the matrix
WriteLine("Matrix:");
WriteLine(MatrixToString(myMatrix1));

// Define the vector
Vector2D myVector1 = new Vector2D
{
    X = 200,
    Y = 100
};

// Print the vector
WriteLine("Original Vector:");
WriteLine(VectorToString(myVector1));

// Multiply the matrix by the vector
Vector2D resultVector = MatrixMultiply(myMatrix1, myVector1);

// Print the resulting vector
WriteLine("Transformed Vector:");
WriteLine(VectorToString(resultVector));
