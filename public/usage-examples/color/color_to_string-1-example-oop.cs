using SplashKitSDK;

namespace ColorToStringExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Color To String", 800, 450);

            Color[] colors = { Color.Red, Color.Green, Color.Blue, Color.Orange, Color.Purple };
            string[] labels = { "Red", "Green", "Blue", "Orange", "Purple" };
            int rectWidth = 120;
            int rectHeight = 200;
            int startX = 60;
            int startY = 130;
            int gap = 20;

            SplashKit.ClearScreen(Color.White);

            SplashKit.DrawText("Color To String", Color.Black, 315, 50);
            SplashKit.DrawText("Each colour displayed with its hex string value", Color.Black, 220, 75);

            for (int i = 0; i < 5; i++)
            {
                int x = startX + i * (rectWidth + gap);

                SplashKit.FillRectangle(colors[i], x, startY, rectWidth, rectHeight);

                // Function used here ↓
                string hex = SplashKit.ColorToString(colors[i]);
                SplashKit.DrawText(labels[i], Color.Black, x + 30, startY + rectHeight + 10);
                SplashKit.DrawText(hex, Color.Black, x + 5, startY + rectHeight + 28);
            }

            SplashKit.RefreshScreen();
            SplashKit.Delay(5000);

            SplashKit.CloseAllWindows();
        }
    }
}
