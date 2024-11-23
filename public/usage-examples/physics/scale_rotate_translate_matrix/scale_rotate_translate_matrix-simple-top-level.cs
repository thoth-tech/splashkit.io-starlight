using static SplashKitSDK.SplashKit;
using SplashKitSDK;

// Open a window for visualization
OpenWindow("Transformation Matrix Visualization", 400, 400);
ClearScreen(ColorWhite());

// Define the scaling factors
Point2D matrixScale = new Point2D() { X = 1.5, Y = 1.2 }; // Scale width and height

// Define the translation (shift by a small amount)
Point2D matrixTranslation = new Point2D() { X = 20, Y = -30 }; // Shift right and up

// Define the rotation angle
double rotation = 45;

// Create a matrix combining scaling, rotation, and translation
Matrix2D transformationMatrix = ScaleRotateTranslateMatrix(matrixScale, rotation, matrixTranslation);

// Define the original triangle points (centered and larger)
Triangle originalTriangle = new Triangle()
{
    Points = new[]
    {
        new Point2D() { X = 200, Y = 150 }, // Top point
        new Point2D() { X = 150, Y = 250 }, // Bottom-left point
        new Point2D() { X = 250, Y = 250 }  // Bottom-right point
    }
};

// Draw the original triangle
FillTriangle(ColorBlue(), originalTriangle);
WriteLine("Original (Blue) Triangle Points:");
foreach (var point in originalTriangle.Points)
{
    WriteLine(PointToString(point));
}

// Transform the triangle using the transformation matrix
ApplyMatrix(transformationMatrix, ref originalTriangle);

// Draw the transformed triangle
FillTriangle(ColorRed(), originalTriangle);
WriteLine("Transformed (Red) Triangle Points:");
foreach (var point in originalTriangle.Points)
{
    WriteLine(PointToString(point));
}

// Refresh the screen
RefreshScreen();
Delay(5000);

CloseAllWindows();
