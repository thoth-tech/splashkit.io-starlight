using SplashKitSDK;
using static SplashKitSDK.SplashKit;

namespace FontHasSizeExample
{
    public class Program
    {
        private static string AvailabilityText(bool available)
        {
            if (available)
            {
                return "Available";
            }

            return "Not Available";
        }

        public static void Main()
        {
            OpenWindow("Font Size Checker", 900, 650);

            Font arialFont = LoadFont("arial font", "arial.ttf");

            int unusedSize = 16;
            int checkedSize = 32;

            bool before16 = FontHasSize(arialFont, unusedSize);
            bool before32 = FontHasSize(arialFont, checkedSize);

            while (!QuitRequested())
            {
                ProcessEvents();
                ClearScreen(ColorWhite());

                DrawText(
                    "font_has_size checks if a font has already been loaded at a selected size.",
                    ColorBlack(),
                    arialFont,
                    24,
                    20,
                    20
                );

                DrawText(
                    "Before using Arial at size 32:",
                    ColorBlue(),
                    arialFont,
                    20,
                    20,
                    90
                );

                DrawText(
                    "Size 16: " + AvailabilityText(before16),
                    ColorBlack(),
                    arialFont,
                    20,
                    40,
                    130
                );

                DrawText(
                    "Size 32: " + AvailabilityText(before32),
                    ColorBlack(),
                    arialFont,
                    20,
                    40,
                    165
                );

                DrawText(
                    "This line is drawn using Arial at size 32.",
                    ColorRed(),
                    arialFont,
                    checkedSize,
                    20,
                    250
                );

                bool after16 = FontHasSize(arialFont, unusedSize);
                bool after32 = FontHasSize(arialFont, checkedSize);

                DrawText(
                    "After drawing text using Arial at size 32:",
                    ColorBlue(),
                    arialFont,
                    20,
                    20,
                    340
                );

                DrawText(
                    "Size 16: " + AvailabilityText(after16),
                    ColorBlack(),
                    arialFont,
                    20,
                    40,
                    380
                );

                DrawText(
                    "Size 32: " + AvailabilityText(after32),
                    ColorBlack(),
                    arialFont,
                    20,
                    40,
                    415
                );

                DrawText(
                    "The size used for drawing becomes available, while the unused size remains unavailable.",
                    ColorDarkGray(),
                    arialFont,
                    20,
                    20,
                    520
                );

                RefreshScreen(60);
            }

            CloseAllWindows();
        }
    }
}
