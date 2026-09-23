using SplashKitSDK;

namespace RectangleCenterExample
{
    public class Program
    {
        public static void Main()
        {
            Window window = new Window("Tracking the Center Point", 800, 600);

            // Slide the rectangle diagonally so the center point keeps moving
            double boxX = 150;
            double boxY = 100;
            double slideStep = 2;

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();
                window.Clear(Color.White);

                Rectangle box = SplashKit.RectangleFrom(boxX, boxY, 300, 200);

                // The center is half the width and half the height in from the corner
                Point2D center = SplashKit.RectangleCenter(box);

                window.DrawRectangle(Color.Black, box);
                window.FillCircle(Color.Red, center.X, center.Y, 8);
                window.DrawText($"Rectangle Center: ({(int)center.X}, {(int)center.Y})", Color.Black, 50, 50);

                // Turn around at each end so the rectangle stays on screen
                boxX = boxX + slideStep;
                boxY = boxY + slideStep;
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
