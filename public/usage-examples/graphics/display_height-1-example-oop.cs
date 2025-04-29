using SplashKitSDK;

namespace DisplayHeightExample
{
    public class Program
    {
        public static void Main()
        {
            // Declare Variables
            Circle ball;
            // -80 to account for title bar and task bar
            int height = SplashKit.DisplayDetails(0).Height - 80;
            double acceleration = 0.8;
            double damping = 0.5;
            double velocity = 0;
            double ballY = 0;
            int radius = 50;

            // Open window with the height of the display
            SplashKit.OpenWindow("Bouncing Ball", 800, height);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ClearScreen(Color.White);

                SplashKit.DrawText($"Display Height: {SplashKit.DisplayDetails(0).Height} Pixels", Color.Black, 25, 25);
                // Set ball details and draw
                ball = SplashKit.CircleAt(400, ballY, radius);
                ball.Fill(Color.Blue);

                // Set acceleration and velocity for ball
                ballY += velocity;
                velocity += acceleration;

                // Check if ball has hit bottom of window to trigger bounce
                if (ballY + radius >= height)
                {
                    // Keep ball in window
                    ballY = height - radius;
                    // Reverse velocity and apply damping
                    velocity = -velocity * damping;
                    // Halt velocity to stop ball bouncing 
                    if (Math.Abs(velocity) < 3)
                    {
                        velocity = 0;
                    }
                }
                SplashKit.RefreshScreen(60);
                SplashKit.ProcessEvents();
            }
            SplashKit.CloseAllWindows();
        }
    }
}
