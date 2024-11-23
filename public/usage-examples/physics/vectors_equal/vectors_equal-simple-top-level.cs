using static SplashKitSDK.SplashKit;
using SplashKitSDK;

// Define the first vector
Vector2D myVector1 = new Vector2D() { X = 200, Y = 100 };

// Define the second vector
Vector2D myVector2 = new Vector2D() { X = -300, Y = 150 };

// Define the third vector
Vector2D myVector3 = new Vector2D() { X = 200, Y = 100 };

// Check if vectors are equal
bool check1_2 = VectorsEqual(myVector1, myVector2);
bool check1_3 = VectorsEqual(myVector1, myVector3);
bool check2_3 = VectorsEqual(myVector2, myVector3);

// Output the results
WriteLine(check1_2);
WriteLine(check1_3);
WriteLine(check2_3);
