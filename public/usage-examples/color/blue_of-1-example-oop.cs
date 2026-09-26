using SplashKitSDK;

namespace BlueOfExample
{
    public class Program
    {
        public static void Main()
        {
            // Open the window for the usage example
            SplashKit.OpenWindow("Reading the Blue Channel", 800, 400);

            Color[] shades =
            {
                SplashKit.RGBAColor(80, 80, 30, 255),
                SplashKit.RGBAColor(80, 80, 130, 255),
                SplashKit.RGBAColor(80, 80, 230, 255)
            };

            string[] labels = { "Low Blue", "Medium Blue", "High Blue" };

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // Draw the background and instructions
                SplashKit.ClearScreen(Color.White);
                SplashKit.DrawText("Blue values for these shades", Color.Black, 240, 40);

                // Draw each shade and use blue_of to read its blue component
                for (int i = 0; i < 3; i++)
                {
                    int value = SplashKit.BlueOf(shades[i]);

                    SplashKit.FillRectangle(shades[i], 80 + i * 240, 140, 160, 80);
                    SplashKit.DrawText(labels[i], Color.Black, 115 + i * 240, 250);
                    SplashKit.DrawText("Blue: " + value.ToString(), Color.Black, 115 + i * 240, 290);
                }

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}
