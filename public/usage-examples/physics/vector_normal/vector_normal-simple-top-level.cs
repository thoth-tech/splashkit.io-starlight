using static SplashKitSDK.SplashKit;
using SplashKitSDK;

// Define vectors
Vector2D myVector1 = new Vector2D() { X = 200, Y = 100 };
Vector2D myVector2 = new Vector2D() { X = 0, Y = 0 };

// Calculate normals
Vector2D myVector1Normal = VectorNormal(myVector1);
Vector2D myVector2Normal = VectorNormal(myVector2);

// Display results
WriteLine("Original Vector: " + VectorToString(myVector1));
WriteLine("Original Vector Magnitude: " + VectorMagnitude(myVector1));
WriteLine("Vector Normal: " + VectorToString(myVector1Normal));
WriteLine("Vector Normal Magnitude: " + VectorMagnitude(myVector1Normal));

WriteLine("Null Vector: " + VectorToString(myVector2));
WriteLine("Null Vector Magnitude: " + VectorMagnitude(myVector2));
WriteLine("Null Vector Normal: " + VectorToString(myVector2Normal));
WriteLine("Null Vector Normal Magnitude: " + VectorMagnitude(myVector2Normal));
