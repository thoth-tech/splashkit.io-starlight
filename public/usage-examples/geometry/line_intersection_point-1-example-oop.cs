using SplashKitSDK;

namespace LineIntersectionPointExample
{
    public class Program
    {
        public static void Main()
        {
            Line spinningLine;
            Line fixedLine;
            Point2D spinningLineRotationPoint;
            float spinningLineRotationDegrees = 0;
            Point2D lineIntersectionCoordinates = new Point2D();

            SplashKit.OpenWindow("Line Intersection Point", 800, 600);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();
                
                // For the spinning line, only one point spins as the other is fixed. The code below increments a variable by 0.01 every frame
                spinningLineRotationDegrees += 0.01f;

                // This code takes the constantly increasing variable and uses trignometry functions to generate a Point2D variable which perpetually moves in a circle
                spinningLineRotationPoint = SplashKit.PointAt(250 + 100 * SplashKit.Cosine(spinningLineRotationDegrees), 250 + 100 * SplashKit.Sine(spinningLineRotationDegrees));

                // The two line's coordinates are set, for a given frame. The fixed line stays static
                spinningLine = SplashKit.LineFrom(SplashKit.PointAt(250, 250), spinningLineRotationPoint);
                fixedLine = SplashKit.LineFrom(SplashKit.PointAt(400, 0), SplashKit.PointAt(800, 400));

                // The 'line_intersection_coordinates' variable holds the Point2D data of where the two lines intersect/ would intersect
                SplashKit.LineIntersectionPoint(spinningLine, fixedLine, ref lineIntersectionCoordinates);

                SplashKit.ClearScreen(Color.White);
                SplashKit.DrawLine(Color.Black, spinningLine);
                SplashKit.DrawLine(Color.Black, fixedLine);
                SplashKit.FillCircle(Color.Red, SplashKit.CircleAt(lineIntersectionCoordinates, 5));
                SplashKit.DrawText($"Position of intersection between the two lines would be at: {(int)lineIntersectionCoordinates.X}, {(int)lineIntersectionCoordinates.Y}", Color.Black, 60, 500);

                SplashKit.RefreshScreen();
            }
            SplashKit.CloseAllWindows();
        }
    }
}