using SplashKitSDK;

namespace ColorBlueExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Color Blue", 600, 400);

            // The height of each bar in the chart
            int[] barHeights = { 120, 200, 90, 260, 160 };

            SplashKit.ClearScreen(Color.White);

            for (int i = 0; i < 5; i++)
            {
                int height = barHeights[i];

                // Bars are drawn upwards from the base line at y = 340
                // Function used here ↓
                SplashKit.FillRectangle(Color.Blue, 80 + i * 100, 340 - height, 60, height);
            }

            // Draw the base line of the chart
            SplashKit.DrawLine(Color.Black, 50, 340, 550, 340);

            SplashKit.DrawText("Bars filled with Color.Blue", Color.Black, 215, 360);

            SplashKit.RefreshScreen();

            SplashKit.Delay(5000);

            SplashKit.CloseAllWindows();
        }
    }
}
