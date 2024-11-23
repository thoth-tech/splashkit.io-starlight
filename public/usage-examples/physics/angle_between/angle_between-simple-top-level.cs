using static SplashKitSDK.SplashKit;
using SplashKitSDK;

// Define the first vector
Vector2D myVector1 = new Vector2D() { X = 200, Y = 100 };

// Define the second vector
Vector2D myVector2 = new Vector2D() { X = -300, Y = 150 };

// Calculate the angle between the two vectors
double vectorAngle = AngleBetween(myVector1, myVector2);

// Output the vectors and the angle
WriteLine(VectorToString(myVector1));
WriteLine(VectorToString(myVector2));
WriteLine(vectorAngle.ToString());