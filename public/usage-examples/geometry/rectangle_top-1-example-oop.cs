using SplashKitSDK;

namespace RectangleTopExample
{
    public class Program
    {
        public static void Main()
        {
            Window window = new Window("Sliding Top Edge", 800, 600);

            // Slide the rectangle up and down so the top edge keeps moving
            double boxY = 100;
            double slideStep = 2;

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();
                window.Clear(Color.White);

                Rectangle box = SplashKit.RectangleFrom(250, boxY, 300, 200);

                // Ask SplashKit where the top edge sits, then mark it across the window
                double topEdge = SplashKit.RectangleTop(box);

                window.DrawRectangle(Color.Black, box);
                window.DrawLine(Color.Red, 0, topEdge, 800, topEdge);
                window.DrawText($"Rectangle Top: {(int)topEdge}", Color.Black, 50, 50);

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
