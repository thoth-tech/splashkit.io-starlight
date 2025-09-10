using static SplashKitSDK.SplashKit;
using SplashKitSDK;

// Define a vector
Vector2D myVector1 = new Vector2D { X = 200, Y = 100 };

// Calculate the squared magnitude of the vector
double myVector1MagnitudeSquared = VectorMagnitudeSqared(myVector1);

// Output the vector and its squared magnitude
WriteLine(VectorToString(myVector1));
WriteLine("Vector Magnitude Squared: " + myVector1MagnitudeSquared.ToString());
