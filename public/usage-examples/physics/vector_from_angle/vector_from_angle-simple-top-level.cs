using static SplashKitSDK.SplashKit;
using SplashKitSDK;

// Open the window
OpenWindow("Vector Visualisations", 300, 300);

// Create vectors from angles
Vector2D myVector1 = VectorFromAngle(15, 250);
Vector2D myVector2 = VectorFromAngle(30, 250);
Vector2D myVector3 = VectorFromAngle(45, 250);
Vector2D myVector4 = VectorFromAngle(60, 250);
Vector2D myVector5 = VectorFromAngle(75, 250);

// Clear the screen
ClearScreen();

// Output the vector details
WriteLine("Vector 1: " + VectorToString(myVector1));
WriteLine("Vector 2: " + VectorToString(myVector2));
WriteLine("Vector 3: " + VectorToString(myVector3));
WriteLine("Vector 4: " + VectorToString(myVector4));
WriteLine("Vector 5: " + VectorToString(myVector5));

// Draw lines representing the vectors
DrawLine(ColorBlue(), LineFrom(myVector1));
DrawLine(ColorRed(), LineFrom(myVector2));
DrawLine(ColorBlack(), LineFrom(myVector3));
DrawLine(ColorPurple(), LineFrom(myVector4));
DrawLine(ColorOrange(), LineFrom(myVector5));

// Refresh the screen
RefreshScreen();

// Wait and close the window
Delay(4000);
CloseAllWindows();
