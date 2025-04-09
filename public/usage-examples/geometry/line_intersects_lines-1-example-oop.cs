using SplashKitSDK;

namespace LineIntersectsLinesExample
{
    public class Program
    {
        public static void Main()
        {
            // Creating two lines
            Line lineA = SplashKit.LineFrom(100, 100, 300, 300);
            Line lineB = SplashKit.LineFrom(300, 100, 100, 300);

            // Adding one line to a list to check intersection
            List<Line> lines = new List<Line> { lineB };

            // Checking if lineA intersects with any line in the list
            bool intersects = SplashKit.LineIntersectsLines(lineA, lines);

            // Opening a window
            SplashKit.OpenWindow("Line Intersection Demo", 800, 600);
            SplashKit.ClearScreen(Color.White);

            // Drawing both lines
            SplashKit.DrawLine(Color.Red, lineA);
            SplashKit.DrawLine(Color.Blue, lineB);

            // Display result
            if (intersects)
            {
                SplashKit.DrawText("Lines Intersect", Color.Green, 320, 550);
            }
            else
            {
                SplashKit.DrawText("No Intersection", Color.Red, 320, 550);
            }

            SplashKit.RefreshScreen();
            
            // Adding Delay for window to close
            SplashKit.Delay(4000);
            SplashKit.CloseAllWindows();
        }
    }
}
