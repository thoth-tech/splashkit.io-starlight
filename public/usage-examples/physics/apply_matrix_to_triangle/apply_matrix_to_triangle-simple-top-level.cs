using static SplashKitSDK.SplashKit;
using SplashKitSDK;

// Open the window
OpenWindow("Apply Matrix to Triangle", 300, 300);

// Clear the screen
ClearScreen(ColorWhite());

// Define the triangle points
Triangle testTriangle1 = new Triangle();
testTriangle1.Points = new Point2D[3];
testTriangle1.Points[0] = new Point2D() { X = 150, Y = 150 };
testTriangle1.Points[1] = new Point2D() { X = 80, Y = 220 };
testTriangle1.Points[2] = new Point2D() { X = 220, Y = 220 };

// Define the transformation matrix (scaling + translation)
Matrix2D scalingMatrix = ScaleMatrix(0.5);
Matrix2D translationMatrix = TranslationMatrix(-25, 50);
Matrix2D combinedMatrix = MatrixMultiply(scalingMatrix, translationMatrix);

// Draw the initial triangle
FillTriangle(ColorBlack(), testTriangle1);
WriteLine("Triangle points before matrix application:");
foreach (Point2D point in testTriangle1.Points)
    WriteLine(PointToString(point));

// Apply the matrix to the triangle
ApplyMatrix(combinedMatrix, ref testTriangle1);

// Draw the transformed triangle
FillTriangle(ColorRed(), testTriangle1);
WriteLine("Triangle points after matrix application:");
foreach (Point2D point in testTriangle1.Points)
    WriteLine(PointToString(point));

// Refresh the screen and wait
RefreshScreen();
Delay(4000);

// Close all windows
CloseAllWindows();
