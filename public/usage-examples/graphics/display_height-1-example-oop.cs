using SplashKitSDK;

namespace DisplayHeightExample
{
    public class Program
    {
        public static void Main()
        {
            // Declare Variables
            Circle ball;
            int height = SplashKit.DisplayDetails(0).Height;
            double acceleration = 0.8;
            double damping = 0.5;
            double velocity = 0;
            double ballY = 0;
            int radius = 50;

            Window wind = SplashKit.OpenWindow("DisplayHeightExample", 800, height);

            while (!SplashKit.QuitRequested())
            {
                wind.Clear(Color.White);

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
                wind.Refresh(60);
                SplashKit.ProcessEvents();
            }
        }
    }
}
