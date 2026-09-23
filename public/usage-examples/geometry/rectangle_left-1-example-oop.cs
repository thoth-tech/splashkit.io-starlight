using SplashKitSDK;

namespace RectangleLeftExample
{
    public class Program
    {
        public static void Main()
        {
            Window window = new Window("Sliding Left Edge", 800, 600);

            // Slide the rectangle side to side so the left edge keeps moving
            double boxX = 150;
            double slideStep = 2;

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();
                window.Clear(Color.White);

                Rectangle box = SplashKit.RectangleFrom(boxX, 200, 300, 200);

                // Ask SplashKit where the left edge sits, then mark it down the window
                double leftEdge = SplashKit.RectangleLeft(box);

                window.DrawRectangle(Color.Black, box);
                window.DrawLine(Color.Red, leftEdge, 0, leftEdge, 600);
                window.DrawText($"Rectangle Left: {(int)leftEdge}", Color.Black, 50, 50);

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
