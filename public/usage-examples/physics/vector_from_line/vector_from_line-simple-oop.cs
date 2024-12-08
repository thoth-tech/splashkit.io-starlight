using SplashKitSDK;

namespace VectorVisualisationDemo
{
    public class Program
    {
        public static void Main()
        {
            // Open the window
            SplashKit.OpenWindow("Vector Visualisations", 300, 300);

            // Define points for lines
            Point2D origin = new Point2D() { X = 150, Y = 150 };
            Point2D line1End = new Point2D() { X = 173, Y = 221 };
            Point2D line2End = new Point2D() { X = 90, Y = 194 };
            Point2D line3End = new Point2D() { X = 90, Y = 106 };
            Point2D line4End = new Point2D() { X = 173, Y = 79 };
            Point2D line5End = new Point2D() { X = 225, Y = 150 };

            // Create lines
            Line line1 = SplashKit.LineFrom(origin, line1End);
            Line line2 = SplashKit.LineFrom(origin, line2End);
            Line line3 = SplashKit.LineFrom(origin, line3End);
            Line line4 = SplashKit.LineFrom(origin, line4End);
            Line line5 = SplashKit.LineFrom(origin, line5End);

            // Convert lines to vectors
            Vector2D myVector1 = SplashKit.VectorFromLine(line1);
            Vector2D myVector2 = SplashKit.VectorFromLine(line2);
            Vector2D myVector3 = SplashKit.VectorFromLine(line3);
            Vector2D myVector4 = SplashKit.VectorFromLine(line4);
            Vector2D myVector5 = SplashKit.VectorFromLine(line5);

            // Clear the screen
            SplashKit.ClearScreen();

            // Output the vector details
            SplashKit.WriteLine("Vector 1: " + SplashKit.VectorToString(myVector1));
            SplashKit.WriteLine("Vector 2: " + SplashKit.VectorToString(myVector2));
            SplashKit.WriteLine("Vector 3: " + SplashKit.VectorToString(myVector3));
            SplashKit.WriteLine("Vector 4: " + SplashKit.VectorToString(myVector4));
            SplashKit.WriteLine("Vector 5: " + SplashKit.VectorToString(myVector5));

            // Draw lines
            SplashKit.DrawLine(SplashKit.ColorBlue(), line1);
            SplashKit.DrawLine(SplashKit.ColorRed(), line2);
            SplashKit.DrawLine(SplashKit.ColorBlack(), line3);
            SplashKit.DrawLine(SplashKit.ColorPurple(), line4);
            SplashKit.DrawLine(SplashKit.ColorOrange(), line5);

            // Refresh the screen
            SplashKit.RefreshScreen();

            // Wait and close the window
            SplashKit.Delay(4000);
            SplashKit.CloseAllWindows();
        }
    }
}
