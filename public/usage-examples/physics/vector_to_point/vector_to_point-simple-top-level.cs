using static SplashKitSDK.SplashKit;
using SplashKitSDK;

// Define a point
Point2D myPoint1 = new Point2D() { X = 200, Y = 100 };

// Create a vector pointing to the point
Vector2D myVector1 = VectorTo(myPoint1);

// Output the vector
WriteLine("my_vector_1 values: " + VectorToString(myVector1));
