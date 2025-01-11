using SplashKitSDK;

namespace VectorVisualisationDemo
{
    public class Program
    {
        public static void Main()
        {
            // Open the window
            SplashKit.OpenWindow("Vector Visualisations", 300, 300);

            // Create vectors from angles
            Vector2D myVector1 = SplashKit.VectorFromAngle(15, 250);
            Vector2D myVector2 = SplashKit.VectorFromAngle(30, 250);
            Vector2D myVector3 = SplashKit.VectorFromAngle(45, 250);
            Vector2D myVector4 = SplashKit.VectorFromAngle(60, 250);
            Vector2D myVector5 = SplashKit.VectorFromAngle(75, 250);

            // Clear the screen
            SplashKit.ClearScreen();

            // Output the vector details
            SplashKit.WriteLine("Vector 1: " + SplashKit.VectorToString(myVector1));
            SplashKit.WriteLine("Vector 2: " + SplashKit.VectorToString(myVector2));
            SplashKit.WriteLine("Vector 3: " + SplashKit.VectorToString(myVector3));
            SplashKit.WriteLine("Vector 4: " + SplashKit.VectorToString(myVector4));
            SplashKit.WriteLine("Vector 5: " + SplashKit.VectorToString(myVector5));

            // Draw lines representing the vectors
            SplashKit.DrawLine(SplashKit.ColorBlue(), SplashKit.LineFrom(myVector1));
            SplashKit.DrawLine(SplashKit.ColorRed(), SplashKit.LineFrom(myVector2));
            SplashKit.DrawLine(SplashKit.ColorBlack(), SplashKit.LineFrom(myVector3));
            SplashKit.DrawLine(SplashKit.ColorPurple(), SplashKit.LineFrom(myVector4));
            SplashKit.DrawLine(SplashKit.ColorOrange(), SplashKit.LineFrom(myVector5));

            // Refresh the screen
            SplashKit.RefreshScreen();

            // Wait and close the window
            SplashKit.Delay(4000);
            SplashKit.CloseAllWindows();
        }
    }
}
