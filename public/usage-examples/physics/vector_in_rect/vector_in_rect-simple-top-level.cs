using static SplashKitSDK.SplashKit;
using SplashKitSDK;

// Open a window for visualisation
OpenWindow("Vector Visualisations", 300, 300);

// Define the rectangle
Rectangle testRectangle1 = new Rectangle()
{
    X = 50,
    Y = 50,
    Width = 200,
    Height = 200
};

// Define two vectors using angles and magnitudes
Vector2D myVector1 = VectorFromAngle(45, 200);
Vector2D myVector2 = VectorFromAngle(10, 200);

// Clear the screen
ClearScreen();

// Draw the rectangle and the vectors
FillRectangle(ColorBlack(), testRectangle1);
DrawLine(ColorRed(), LineFrom(myVector1));
DrawLine(ColorBlue(), LineFrom(myVector2));

// Check if vectors are inside the rectangle
if (VectorInRect(myVector1, testRectangle1))
    WriteLine("Red vector in rectangle!");
if (VectorInRect(myVector2, testRectangle1))
    WriteLine("Blue vector in rectangle!");

// Refresh the screen and wait
RefreshScreen();
Delay(4000);

// Close all windows
CloseAllWindows();
