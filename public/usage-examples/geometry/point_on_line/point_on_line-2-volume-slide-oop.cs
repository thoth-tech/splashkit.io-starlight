using SplashKitSDK;

namespace PointOnLine
{
    public class Program
    {
        public static void Main()
        {
            // Variable Declarations
            double barX = 100;
            Line slider = SplashKit.LineFrom(100, 300, 500, 300);
            Line bar = SplashKit.LineFrom(barX, 310, barX, 290);
            double percent = 0;
            string volume = "Volume: ";

            // Create window and draw initial Lines
            Window window = new Window("Volume Slider", 600, 600);
            window.Clear(Color.White);

            window.DrawLine(Color.Black, slider);
            window.DrawLine(Color.Black, bar);
            window.DrawText(volume + percent.ToString(), Color.Black, 200, 450);
            window.Refresh();

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // Check if user is holding click on the bar Line
                while (SplashKit.MouseDown(MouseButton.LeftButton) && SplashKit.PointOnLine(SplashKit.MousePosition(), bar))
                {
                    window.Clear(Color.White);
                    barX = SplashKit.MousePosition().X; // sets barX value to mouse X value
                    percent = ((barX - 100) / (500 - 100)) * 100; // convert barX position to percent value
                    bar = SplashKit.LineFrom(barX, 310, barX, 290);

                    // Redraw Lines and volume text
                    window.DrawLine(Color.Black, bar);
                    window.DrawLine(Color.Black, slider);
                    window.DrawText(volume + percent.ToString(), Color.Black, 200, 450);
                    window.Refresh();
                    SplashKit.ProcessEvents();
                }
            }
            window.Close();
        }
    }
}
