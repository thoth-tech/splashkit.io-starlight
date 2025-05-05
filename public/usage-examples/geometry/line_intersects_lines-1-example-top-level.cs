using static SplashKitSDK.SplashKit;

// Creating two lines
line lineA = LineFrom(100, 100, 300, 300);
line lineB = LineFrom(300, 100, 100, 300);

// Creating a list of lines to compare with
List<line> lines = new List<line> { lineB };

// Checking if lineA intersects with any line in the list
bool intersects = LineIntersectsLines(lineA, lines);

// Opening a window
OpenWindow("Line Intersection Demo", 800, 600);
ClearScreen(Color.White);

// Drawing the lines
DrawLine(Color.Red, lineA);
DrawLine(Color.Blue, lineB);

// Show message based on result
if (intersects)
{
    DrawText("Lines Intersect", Color.Green, 320, 550);
}
else
{
    DrawText("No Intersection", Color.Red, 320, 550);
}

RefreshScreen();
Delay(4000);
CloseAllWindows();
