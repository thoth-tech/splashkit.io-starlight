using SplashKitSDK;

namespace ColorToStringExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Color To String", 800, 500);

            Color[] shades =
            {
                SplashKit.RGBAColor(180, 30, 80, 255),
                SplashKit.RGBAColor(40, 140, 220, 255),
                SplashKit.RGBAColor(90, 180, 100, 255)
            };

            string[] names = { "Rose", "Blue", "Green" };

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                SplashKit.ClearScreen(Color.White);
                SplashKit.DrawText("Color to string examples", Color.Black, 260, 40);

                for (int i = 0; i < 3; i++)
                {
                    string value = SplashKit.ColorToString(shades[i]);

                    SplashKit.FillRectangle(shades[i], 90 + i * 240, 150, 160, 100);
                    SplashKit.DrawText(names[i], Color.Black, 140 + i * 240, 280);
                    SplashKit.DrawText(value, Color.Black, 110 + i * 240, 320);
                }

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}