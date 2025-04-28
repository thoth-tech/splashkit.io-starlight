using SplashKitSDK;
using static SplashKitSDK.SplashKit;

Line spinningLine;
Line fixedLine;
Point2D spinningLineRotationPoint;
float spinningLineRotationDegrees = 0;
Point2D lineIntersectionCoordinates = new Point2D();

OpenWindow("Line Intersection Point", 800, 600);

while (!QuitRequested())
{
    ProcessEvents();
                
    // For the spinning line, only one point spins as the other is fixed. The code below increments a variable by 0.01 every frame
    spinningLineRotationDegrees += 0.01f;

    // This code takes the constantly increasing variable and uses trignometry functions to generate a Point2D variable which perpetually moves in a circle
    spinningLineRotationPoint = PointAt(250 + 100 * Cosine(spinningLineRotationDegrees), 250 + 100 * Sine(spinningLineRotationDegrees));

    // The two line's coordinates are set, for a given frame. The fixed line stays static
    spinningLine = LineFrom(PointAt(250, 250), spinningLineRotationPoint);
    fixedLine = LineFrom(PointAt(400, 0), PointAt(800, 400));

    // The 'line_intersection_coordinates' variable holds the Point2D data of where the two lines intersect/ would intersect
    LineIntersectionPoint(spinningLine, fixedLine, ref lineIntersectionCoordinates);

    ClearScreen(ColorWhite());
    DrawLine(ColorBlack(), spinningLine);
    DrawLine(ColorBlack(), fixedLine);
    FillCircle(ColorRed(), CircleAt(lineIntersectionCoordinates, 5));
    DrawText($"Position of intersection between the two lines would be at: {(int)lineIntersectionCoordinates.X}, {(int)lineIntersectionCoordinates.Y}", ColorBlack(), 60, 500);

    RefreshScreen();
}
CloseAllWindows();