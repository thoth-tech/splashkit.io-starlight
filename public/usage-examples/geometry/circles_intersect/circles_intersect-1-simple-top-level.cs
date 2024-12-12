using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Read the data for Circle A
WriteLine("X coordinate for circle A: ");
int X_A = ConvertToInteger(ReadLine());
WriteLine("Y coordinate for circle A: ");
int Y_A = ConvertToInteger(ReadLine());
WriteLine("Radient for circle A: ");
int R_A = ConvertToInteger(ReadLine());

// Create circle A based on the user's data
Circle A = CircleAt(X_A, Y_A, R_A);

// Read the data for Circle B
WriteLine("X coordinate for circle B: ");
int X_B = ConvertToInteger(ReadLine());
WriteLine("Y coordinate for circle B: ");
int Y_B = ConvertToInteger(ReadLine());
WriteLine("Radient for circle B: ");
int R_B = ConvertToInteger(ReadLine());

// Create circle B based on the user's data
Circle B = CircleAt(X_B, Y_B, R_B);

// Detect if the circles intersect
if (CirclesIntersect(A, B))
{
    WriteLine("The circles intersect!");
}
else
{
    WriteLine("The circles do not intersect!");
}

// Create a window 
OpenWindow("Circle Intersect", 800, 600);
ClearScreen();

// Draw the circles based on the data given by user
DrawCircle(Color.Red, X_A, Y_A, R_A);
DrawCircle(Color.Red, X_B, Y_B, R_B);

RefreshScreen();
Delay(4000);
CloseAllWindows();

