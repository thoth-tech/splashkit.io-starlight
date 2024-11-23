using static SplashKitSDK.SplashKit;
using SplashKitSDK;

// Define the first vector
Vector2D myVector1 = new Vector2D() { X = 200, Y = 100 };

// Define the second vector
Vector2D myVector2 = new Vector2D() { X = -300, Y = 150 };

// Subtract the vectors
Vector2D myVector3 = VectorSubtract(myVector1, myVector2);

// Output the result of the subtraction
WriteLine(VectorToString(myVector3));
