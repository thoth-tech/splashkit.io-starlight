using static SplashKitSDK.SplashKit;
using SplashKitSDK;

// Define the vector
Vector2D myVector1 = new Vector2D() { X = 200, Y = 100 };

// Calculate the angle of the vector
double myVector1Angle = VectorAngle(myVector1);

// Output the results
WriteLine("Vector 1: " + VectorToString(myVector1));
WriteLine("Vector Angle: " + myVector1Angle);