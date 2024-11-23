using static SplashKitSDK.SplashKit;
using SplashKitSDK;

// Define the first vector
Vector2D myVector1 = new Vector2D() { X = 200, Y = 100 };

// Define the second vector
Vector2D myVector2 = new Vector2D() { X = -300, Y = 150 };

// Calculate the dot product
double vectorDotProduct = DotProduct(myVector1, myVector2);

// Output vector details and the dot product
WriteLine(VectorToString(myVector1));
WriteLine(VectorToString(myVector2));
WriteLine(vectorDotProduct);
