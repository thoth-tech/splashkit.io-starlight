using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Define the vector
Vector2D myVector1 = new Vector2D() { X = 200, Y = 100 };
double vectorScale = 5;

// Multiply the vector by a scalar value
WriteLine("Multiply Vector by: " + vectorScale);
Vector2D myVector1Multiplied = VectorMultiply(myVector1, vectorScale);

// Output the original and multiplied vectors
WriteLine("Original Vector: " + VectorToString(myVector1));
WriteLine("Vector multiplied by scaling value: " + VectorToString(myVector1Multiplied));
