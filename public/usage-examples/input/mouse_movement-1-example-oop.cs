using SplashKitSDK;

namespace MouseMovementExample
{
    public static class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Mouse Movement Display", 800, 600);

            double circleX = 400;
            double circleY = 300;

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                Vector2D movement = SplashKit.MouseMovement();

                circleX += movement.X;
                circleY += movement.Y;

                SplashKit.ClearScreen(Color.White);

                SplashKit.DrawText("Move the mouse to see mouse_movement() values.", Color.Black, 20, 20);
                SplashKit.DrawText("Movement X: " + movement.X, Color.Black, 20, 60);
                SplashKit.DrawText("Movement Y: " + movement.Y, Color.Black, 20, 100);

                SplashKit.FillCircle(Color.Blue, circleX, circleY, 15);
                SplashKit.DrawCircle(Color.Black, circleX, circleY, 15);

                SplashKit.DrawLine(Color.Red, circleX, circleY, circleX + movement.X * 5, circleY + movement.Y * 5);

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}