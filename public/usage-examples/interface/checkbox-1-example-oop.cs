using SplashKitSDK;

namespace CheckboxExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SplashKit.OpenWindow("Checkbox Example", 700, 500);

            bool showGrid = false;
            bool soundEnabled = true;
            bool darkBackground = false;

            Rectangle panelArea = SplashKit.RectangleFrom(40, 90, 280, 150);
            Rectangle positionedCheckbox = SplashKit.RectangleFrom(380, 120, 220, 40);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                if (darkBackground)
                {
                    SplashKit.ClearScreen(SplashKit.ColorDarkSlateGray());
                }
                else
                {
                    SplashKit.ClearScreen(SplashKit.ColorWhite());
                }

                Color textColor;

                if (darkBackground)
                {
                    textColor = SplashKit.ColorWhite();
                }
                else
                {
                    textColor = SplashKit.ColorBlack();
                }

                if (showGrid)
                {
                    for (int x = 0; x < 700; x += 50)
                    {
                        SplashKit.DrawLine(
                            SplashKit.ColorLightGray(),
                            x,
                            0,
                            x,
                            500
                        );
                    }

                    for (int y = 0; y < 500; y += 50)
                    {
                        SplashKit.DrawLine(
                            SplashKit.ColorLightGray(),
                            0,
                            y,
                            700,
                            y
                        );
                    }
                }

                SplashKit.DrawText(
                    "SplashKit Checkbox Example",
                    textColor,
                    40,
                    35
                );

                if (SplashKit.StartPanel("Options", panelArea))
                {
                    showGrid = SplashKit.Checkbox(
                        "Show Grid",
                        showGrid
                    );

                    soundEnabled = SplashKit.Checkbox(
                        "Sound",
                        "Enabled",
                        soundEnabled
                    );

                    SplashKit.EndPanel("Options");
                }

                darkBackground = SplashKit.Checkbox(
                    "Dark Background",
                    darkBackground,
                    positionedCheckbox
                );

                SplashKit.DrawText(
                    "Try clicking each checkbox",
                    textColor,
                    380,
                    190
                );

                SplashKit.DrawInterface();
                SplashKit.RefreshScreen(60);
            }
        }
    }
}
