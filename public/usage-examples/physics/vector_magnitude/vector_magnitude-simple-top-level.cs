using static SplashKitSDK.SplashKit;
using SplashKitSDK;

// Define a vector
Vector2D myVector1 = new Vector2D { X = 200, Y = 100 };

// Calculate the magnitude of the vector
double myVector1Magnitude = VectorMagnitude(myVector1);

// Output the vector and its magnitude
WriteLine(VectorToString(myVector1));
WriteLine("Vector Magnitude: " + myVector1Magnitude.ToString());
