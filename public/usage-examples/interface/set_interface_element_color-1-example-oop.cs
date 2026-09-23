using SplashKitSDK;

namespace SetInterfaceElementColorExample
{
    public class Program
    {
        public static void Main()
        {
            Window window = new Window(
                "Interface Element Contrast",
                700,
                420
            );

            Color elementColor = Color.RGBColor(70, 160, 220);
            float contrast = 0.0f;

            while (!window.CloseRequested)
            {
                SplashKit.ProcessEvents();

                // Change the interface contrast using number keys
                if (SplashKit.KeyTyped(KeyCode.Num1Key))
                {
                    contrast = 0.0f;
                }

                if (SplashKit.KeyTyped(KeyCode.Num2Key))
                {
                    contrast = 1.0f;
                }

                // Apply the selected color and contrast to the interface
                SplashKit.SetInterfaceElementColor(
                    elementColor,
                    contrast
                );

                window.Clear(Color.White);

                window.DrawText(
                    "Press 1 for minimum contrast or 2 for maximum contrast",
                    Color.Black,
                    90,
                    80
                );

                window.DrawText(
                    "Current contrast: " + contrast,
                    Color.Black,
                    240,
                    130
                );

                SplashKit.Button(
                    "Interface Button",
                    SplashKit.RectangleFrom(
                        230,
                        200,
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