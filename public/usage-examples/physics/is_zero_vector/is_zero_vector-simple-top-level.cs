using static SplashKitSDK.SplashKit;
using SplashKitSDK;

// Define the first vector
Vector2D myVector1 = new Vector2D() { X = 200, Y = 100 };

// Define the second vector (zero vector)
Vector2D myVector2 = new Vector2D() { X = 0, Y = 0 };

// Check if the vectors are zero vectors
bool checkZero1 = IsZeroVector(myVector1);
bool checkZero2 = IsZeroVector(myVector2);

// Output the results with descriptive messages
WriteLine("Checking if myVector1 is a zero vector:");
WriteLine(checkZero1 ? "myVector1 is a zero vector." : "myVector1 is not a zero vector.");

WriteLine("Checking if myVector2 is a zero vector:");
WriteLine(checkZero2 ? "myVector2 is a zero vector." : "myVector2 is not a zero vector.");
