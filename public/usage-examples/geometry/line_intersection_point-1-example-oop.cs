using SplashKitSDK;

namespace LineIntersectionPoint
{
    public class Program
    {
        public static void Main()
        {
            new Window("Line Intersection Point", 800, 600);
            
            Line line1;
            Line line2;
            float line1_rotation_degrees = 0;
            bool boolean;
            Point2D line1_rotation_coordinates;
            Point2D line_intersection_coordinates = new Point2D();

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();
                
                line1_rotation_degrees += 0.01f;
                line1_rotation_coordinates = SplashKit.PointAt(250 + 100 * SplashKit.Cosine(line1_rotation_degrees), 250 + 100 * SplashKit.Sine(line1_rotation_degrees));
        
                line1 = SplashKit.LineFrom(SplashKit.PointAt(250, 250), line1_rotation_coordinates);
                line2 = SplashKit.LineFrom(SplashKit.PointAt(400, 0), SplashKit.PointAt(800, 400));

                // The boolean variable that this function returns to isn't relevant
                // The 'line_intersection_coordinates' variable as noted here holds the Point2D data of where the two lines would intersect instead
                boolean = SplashKit.LineIntersectionPoint(line1, line2, ref line_intersection_coordinates);

                SplashKit.ClearScreen();
                SplashKit.DrawLine(Color.Black, line1);
                SplashKit.DrawLine(Color.Black, line2);
                SplashKit.FillCircle(Color.Red, SplashKit.CircleAt(line_intersection_coordinates, 5));
                SplashKit.DrawText("Position of intersection between the two lines would be at: " + SplashKit.PointToString(line_intersection_coordinates), Color.Black, 60, 500);

                SplashKit.RefreshScreen();
            }
            SplashKit.CloseAllWindows();
        }
    }
}