using SplashKitSDK;

namespace RectangleBottomExample
{
    public class Program
    {
        public static void Main()
        {
            Window window = new Window("Sliding Bottom Edge", 800, 600);

            // Slide the rectangle up and down so the bottom edge keeps moving
            double boxY = 100;
            double slideStep = 2;

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();
                window.Clear(Color.White);

                Rectangle box = SplashKit.RectangleFrom(250, boxY, 300, 200);

                // The bottom edge is the top plus the height, so SplashKit works it out for us
                double bottomEdge = SplashKit.RectangleBottom(box);

                window.DrawRectangle(Color.Black, box);
                window.DrawLine(Color.Red, 0, bottomEdge, 800, bottomEdge);
                window.DrawText($"Rectangle Bottom: {(int)bottomEdge}", Color.Black, 50, 50);

                // Turn around at each end so the rectangle stays on screen
                boxY = boxY + slideStep;
                if (boxY > 300 || boxY < 100)
                {
                    slideStep = -slideStep;
                }

                window.Refresh(60);
            }

            window.Close();
        }
    }
}
