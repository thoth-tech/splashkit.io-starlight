using SplashKitSDK;

namespace VectorVisualisations
{
    public class Program
    {
        public static void Main()
        {
            // Open a window for visualisation
            SplashKit.OpenWindow("Vector Visualisations", 300, 300);

            // Define the rectangle
            Rectangle testRectangle1 = new Rectangle()
            {
                X = 50,
                Y = 50,
                Width = 200,
                Height = 200
            };

            // Define two vectors using angles and magnitudes
            Vector2D myVector1 = SplashKit.VectorFromAngle(45, 200);
            Vector2D myVector2 = SplashKit.VectorFromAngle(10, 200);

            // Clear the screen
            SplashKit.ClearScreen();

            // Draw the rectangle and the vectors
            SplashKit.FillRectangle(SplashKit.ColorBlack(), testRectangle1);
            SplashKit.DrawLine(SplashKit.ColorRed(), SplashKit.LineFrom(myVector1));
            SplashKit.DrawLine(SplashKit.ColorBlue(), SplashKit.LineFrom(myVector2));

            // Check if vectors are inside the rectangle
            if (SplashKit.VectorInRect(myVector1, testRectangle1))
                SplashKit.WriteLine("Red vector in rectangle!");
            if (SplashKit.VectorInRect(myVector2, testRectangle1))
                SplashKit.WriteLine("Blue vector in rectangle!");

            // Refresh the screen and wait
            SplashKit.RefreshScreen();
            SplashKit.Delay(4000);

            // Close all windows
            SplashKit.CloseAllWindows();
        }
    }
}
