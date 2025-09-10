using SplashKitSDK;

namespace ClosestPointOnLine
{
    public class Program
    {
        public static void Main()
        {
            Window window = SplashKit.OpenWindow("Closest Point On Line", 800, 600);

            // Create line for which our point will be attached to
            Line diagonalLine = new Line
            {
                StartPoint = new Point2D { X = 200, Y = 150 },
                EndPoint = new Point2D { X = 600, Y = 450 }
            };

            while (!window.CloseRequested)
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen(Color.White);
                SplashKit.DrawLine(Color.Black, diagonalLine);

                // Use our mouse position for calculating the closest point on line
                Point2D mousePos = SplashKit.MousePosition();
                Point2D closest = SplashKit.ClosestPointOnLine(mousePos, diagonalLine);

                // Visualize the mouse position and the closest point on the line
                SplashKit.FillCircle(Color.Red, mousePos.X, mousePos.Y, 5);
                SplashKit.FillCircle(Color.Green, closest.X, closest.Y, 5);

                SplashKit.RefreshScreen();
            }

        }
    }
}

