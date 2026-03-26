using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        // Open the window for the usage example
        SplashKit.OpenWindow("Purple Shade Brightness", 800, 400);

        Color[] shades =
        {
            SplashKit.RGBAColor(70, 30, 100, 255),
            SplashKit.RGBAColor(140, 70, 180, 255),
            SplashKit.RGBAColor(210, 170, 240, 255)
        };

        string[] names = { "Dark Purple", "Medium Purple", "Light Purple" };

        while (!SplashKit.WindowCloseRequested("Purple Shade Brightness"))
        {
            SplashKit.ProcessEvents();

            // Draw the background and instructions
            SplashKit.ClearScreen(Color.White);
            SplashKit.DrawText("Brightness values of purple shades", Color.Black, 210, 40);

            // Draw each shade and its brightness value
            for (int i = 0; i < 3; i++)
            {
                double value = SplashKit.BrightnessOf(shades[i]);

                SplashKit.FillCircle(shades[i], 150 + i * 240, 180, 55);
                SplashKit.DrawText(names[i], Color.Black, 105 + i * 240, 260);
                SplashKit.DrawText("Brightness: " + value.ToString(), Color.Black, 75 + i * 240, 300);
            }

            SplashKit.RefreshScreen(60);
        }
    }
}