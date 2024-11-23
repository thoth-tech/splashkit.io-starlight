using static SplashKitSDK.SplashKit;
using SplashKitSDK;

namespace VectorVisualisationDemo
{
    public class Program
    {
        public static void Main()
        {
            // Open the window
            OpenWindow("Vector Visualisations", 300, 300);

            // Define points for lines
            Point2D origin = new Point2D() { X = 150, Y = 150 };
            Point2D line1End = new Point2D() { X = 173, Y = 221 };
            Point2D line2End = new Point2D() { X = 90, Y = 194 };
            Point2D line3End = new Point2D() { X = 90, Y = 106 };
            Point2D line4End = new Point2D() { X = 173, Y = 79 };
            Point2D line5End = new Point2D() { X = 225, Y = 150 };

            // Create lines
            Line line1 = LineFrom(origin, line1End);
            Line line2 = LineFrom(origin, line2End);
            Line line3 = LineFrom(origin, line3End);
            Line line4 = LineFrom(origin, line4End);
            Line line5 = LineFrom(origin, line5End);

            // Convert lines to vectors
            Vector2D myVector1 = VectorFromLine(line1);
            Vector2D myVector2 = VectorFromLine(line2);
            Vector2D myVector3 = VectorFromLine(line3);
            Vector2D myVector4 = VectorFromLine(line4);
            Vector2D myVector5 = VectorFromLine(line5);

            // Clear the screen
            ClearScreen();

            // Output the vector details
            WriteLine("Vector 1: " + VectorToString(myVector1));
            WriteLine("Vector 2: " + VectorToString(myVector2));
            WriteLine("Vector 3: " + VectorToString(myVector3));
            WriteLine("Vector 4: " + VectorToString(myVector4));
            WriteLine("Vector 5: " + VectorToString(myVector5));

            // Draw lines
            DrawLine(ColorBlue(), line1);
            DrawLine(ColorRed(), line2);
            DrawLine(ColorBlack(), line3);
            DrawLine(ColorPurple(), line4);
            DrawLine(ColorOrange(), line5);

            // Refresh the screen
            RefreshScreen();

            // Wait and close the window
            Delay(4000);
            CloseAllWindows();
        }
    }
}
