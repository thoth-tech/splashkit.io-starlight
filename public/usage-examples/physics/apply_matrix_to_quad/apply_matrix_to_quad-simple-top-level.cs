using static SplashKitSDK.SplashKit;
using SplashKitSDK;

// Open the window
OpenWindow("Apply Matrix", 400, 400);

// Clear the screen
ClearScreen(ColorWhite());

// Define the quad points
Quad testRectangle1 = new Quad();
testRectangle1.Points = new Point2D[4];
testRectangle1.Points[0] = new Point2D() { X = 150, Y = 150 };
testRectangle1.Points[1] = new Point2D() { X = 250, Y = 150 };
testRectangle1.Points[2] = new Point2D() { X = 150, Y = 250 };
testRectangle1.Points[3] = new Point2D() { X = 250, Y = 250 };

// Define the transformation matrix (scaling + translation)
Matrix2D scalingMatrix = ScaleMatrix(0.5);
Matrix2D translationMatrix = TranslationMatrix(50, 50);
Matrix2D combinedMatrix = MatrixMultiply(scalingMatrix, translationMatrix);

// Draw the initial quad
FillQuad(ColorBlack(), testRectangle1);
WriteLine("Quad points before matrix application:");
for (int i = 0; i < 4; i++)
    WriteLine(PointToString(testRectangle1.Points[i]));

// Apply the matrix to the quad
ApplyMatrix(combinedMatrix, ref testRectangle1);

// Draw the transformed quad
FillQuad(ColorRed(), testRectangle1);
WriteLine("Quad points after matrix application:");
for (int i = 0; i < 4; i++)
    WriteLine(PointToString(testRectangle1.Points[i]));

// Refresh the screen and wait
RefreshScreen();
Delay(4000);

// Close all windows
CloseAllWindows();
