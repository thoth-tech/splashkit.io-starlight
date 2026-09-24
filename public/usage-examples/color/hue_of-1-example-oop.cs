using SplashKitSDK;

namespace HueOfExample
{
    public class Program
    {
        public static void Main()
        {
            Window window = SplashKit.OpenWindow("Hue Of", 800, 600);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                double selectedHue =
                    SplashKit.MouseX() / SplashKit.ScreenWidth();

                if (selectedHue < 0.0)
                {
                    selectedHue = 0.0;
                }
                else if (selectedHue > 1.0)
                {
                    selectedHue = 1.0;
                }

                Color selectedColor =
                    SplashKit.HSBColor(selectedHue, 1.0, 1.0);

                // Get the hue component of the selected color
                double hue = SplashKit.HueOf(selectedColor);

                SplashKit.ClearScreen(Color.White);

                SplashKit.FillRectangle(
                    selectedColor,
                    100,
                    120,
                    600,
                    300
                );

                SplashKit.DrawRectangle(
                    Color.Black,
                    100,
                    120,
                    600,
                    300
                );

                SplashKit.DrawText(
                    "Move the mouse left and right to change the color",
                    Color.Black,
                    150,
                    60
                );

                SplashKit.DrawText(
                    $"Hue: {hue:F3}",
                    Color.Black,
                    330,
                    460
                );

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}