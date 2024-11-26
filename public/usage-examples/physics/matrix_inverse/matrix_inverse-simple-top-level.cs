using static SplashKitSDK.SplashKit;
using SplashKitSDK;

// Define a transformation matrix (scaling)
Matrix2D scalingMatrix = ScaleMatrix(2.0);

// Print the scaling matrix
WriteLine("Scaling Matrix:");
WriteLine(MatrixToString(scalingMatrix));

// Calculate the inverse of the scaling matrix
Matrix2D inverseMatrix = MatrixInverse(scalingMatrix);

// Print the inverse matrix
WriteLine("Inverse Matrix:");
WriteLine(MatrixToString(inverseMatrix));

// Define a point
Point2D originalPoint = new Point2D { X = 100, Y = 100 };
WriteLine($"Original Point: {PointToString(originalPoint)}");

// Transform the point
Point2D transformedPoint = MatrixMultiply(scalingMatrix, originalPoint);
WriteLine($"Transformed Point: {PointToString(transformedPoint)}");

// Apply the inverse transformation to recover the original point
Point2D recoveredPoint = MatrixMultiply(inverseMatrix, transformedPoint);
WriteLine($"Recovered Point: {PointToString(recoveredPoint)}");
