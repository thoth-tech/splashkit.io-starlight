using SplashKitSDK;

namespace RectangleRightExample
{
    public class Program
    {
        public static void Main()
        {
            Window window = new Window("Sliding Right Edge", 800, 600);

            // Slide the rectangle side to side so the right edge keeps moving
            double boxX = 150;
            double slideStep = 2;

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();
                window.Clear(Color.White);

                Rectangle box = SplashKit.RectangleFrom(boxX, 200, 300, 200);

                // The right edge is the left plus the width, so SplashKit works it out for us
                double rightEdge = SplashKit.RectangleRight(box);

                window.DrawRectangle(Color.Black, box);
                window.DrawLine(Color.Red, rightEdge, 0, rightEdge, 600);
                window.DrawText($"Rectangle Right: {(int)rightEdge}", Color.Black, 50, 50);

                // Turn around at each end so the rectangle stays on screen
                boxX = boxX + slideStep;
                if (boxX > 350 || boxX < 150)
                {
                    slideStep = -slideStep;
                }

                window.Refresh(60);
            }

            window.Close();
        }
    }
}
