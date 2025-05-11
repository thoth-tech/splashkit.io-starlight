using SplashKitSDK;
using static SplashKitSDK.SplashKit;

new Window("Line Intersection Point", 800, 600);
            
Line line1;
Line line2;
float line1RotationDegrees = 0;
bool boolean;
Point2D line1RotationCoordinates;
Point2D lineIntersectionCoordinates = new Point2D();

while (!QuitRequested())
{
    ProcessEvents();
                
    line1RotationDegrees += 0.01f;
    line1RotationCoordinates = PointAt(250 + 100 * Cosine(line1RotationDegrees), 250 + 100 * Sine(line1RotationDegrees));
        
    line1 = LineFrom(PointAt(250, 250), line1RotationCoordinates);
    line2 = LineFrom(PointAt(400, 0), PointAt(800, 400));

    // The boolean variable that this function returns to isn't relevant
    // The 'line_intersection_coordinates' variable as noted here holds the Point2D data of where the two lines would intersect instead
    boolean = LineIntersectionPoint(line1, line2, ref lineIntersectionCoordinates);

    ClearScreen();
    DrawLine(Color.Black, line1);
    DrawLine(Color.Black, line2);
    FillCircle(Color.Red, CircleAt(lineIntersectionCoordinates, 5));
    DrawText("Position of intersection between the two lines would be at: " + PointToString(lineIntersectionCoordinates), Color.Black, 60, 500);

    RefreshScreen();
}
CloseAllWindows();