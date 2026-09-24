using SplashKitSDK;

namespace AlphaOfExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Alpha Of", 800, 450);

            int[] alphas = { 50, 100, 150, 200, 255 };
            int rectWidth = 120;
            int rectHeight = 200;
            int startX = 60;
            int startY = 140;
            int gap = 20;

            SplashKit.ClearScreen(Color.White);

            // Draw a background stripe so transparency is visible
            SplashKit.FillRectangle(Color.LightBlue, 0, startY, 800, rectHeight);

            SplashKit.DrawText("Transparency Layers", Color.Black, 300, 55);
            SplashKit.DrawText("Same colour at different alpha values (light blue shows through)", Color.Black, 155, 80);

            for (int i = 0; i < 5; i++)
            {
                Color c = SplashKit.RgbaColor(200, 50, 50, alphas[i]);
                int x = startX + i * (rectWidth + gap);

                SplashKit.FillRectangle(c, x, startY, rectWidth, rectHeight);

                // Function used here ↓
                int a = SplashKit.AlphaOf(c);
                SplashKit.DrawText("Alpha: " + a, Color.Black, x + 22, startY + rectHeight + 12);
            }

            SplashKit.RefreshScreen();
            SplashKit.Delay(5000);

            SplashKit.CloseAllWindows();
        }
    }
}
