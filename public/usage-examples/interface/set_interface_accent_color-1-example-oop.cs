using SplashKitSDK;

namespace SetInterfaceAccentColorExample
{
    public class Program
    {
        public static void Main()
        {
            Window window = new Window(
                "Interface Accent Contrast",
                700,
                420
            );

            Color accentColor = Color.RGBColor(230, 80, 120);
            float contrast = 0.0f;

            while (!window.CloseRequested)
            {
                SplashKit.ProcessEvents();

                // Change the interface accent contrast using number keys
                if (SplashKit.KeyTyped(KeyCode.Num1Key))
                {
                    contrast = 0.0f;
                }

                if (SplashKit.KeyTyped(KeyCode.Num2Key))
                {
                    contrast = 1.0f;
                }

                // Apply the selected accent color and contrast to the interface
                SplashKit.SetInterfaceAccentColor(
                    accentColor,
                    contrast
                );

                window.Clear(Color.White);

                window.DrawText(
                    "Press 1 for minimum accent or 2 for maximum accent",
                    Color.Black,
                    90,
                    70
                );

                window.DrawText(
                    "Hover over the button to see the accent effect",
                    Color.Black,
                    120,
                    110
                );

                window.DrawText(
                    "Current contrast: " + contrast,
                    Color.Black,
                    240,
                    150
                );

                SplashKit.Button(
                    "Hover Over Me",
                    SplashKit.RectangleFrom(
                        230,
                        220,
                        240,
                        60
                    )
                );

                SplashKit.DrawInterface();
                window.Refresh(60);
            }

            window.Close();
        }
    }
}