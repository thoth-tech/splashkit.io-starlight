using static SplashKitSDK.SplashKit;
using SplashKitSDK;

// Open the window
OpenWindow("Apply Matrix", 300, 300);

// Clear the screen
ClearScreen(Color.White);

// Define the triangle points
Triangle testTriangle1 = new Triangle();
Point2D top = new Point2D() { X = 150, Y = 150 };
Point2D left = new Point2D() { X = 130, Y = 170 };
Point2D right = new Point2D() { X = 170, Y = 170 };

testTriangle1.Points[0] = top;
testTriangle1.Points[1] = left;
testTriangle1.Points[2] = right;

// Create and populate the matrix
Matrix2D myMatrix1 = new Matrix2D();
for (int i = 0; i < 3; i++)
    for (int j = 0; j < 3; j++)
        myMatrix1.Elements[i, j] = 0.5;

// Draw the initial triangle
DrawTriangle(Color.Black, testTriangle1);
WriteLine("Triangle points before matrix application:");
foreach (Point2D point in testTriangle1.Points)
    WriteLine(PointToString(point));

// Apply the matrix to the triangle
ApplyMatrix(myMatrix1, testTriangle1);

// Draw the transformed triangle
DrawTriangle(Color.Red, testTriangle1);
WriteLine("Triangle points after matrix application:");
foreach (Point2D point in testTriangle1.Points)
    WriteLine(PointToString(point));

// Refresh the screen and wait
RefreshScreen();
Delay(4000);

// Close all windows
CloseAllWindows();
