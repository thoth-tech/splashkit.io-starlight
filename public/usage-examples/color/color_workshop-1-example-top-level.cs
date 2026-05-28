using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Color Workshop", 960, 540);

const int segmentCount = 16;
const int stripX = 40;
const int stripY = 90;
const int stripWidth = 880;
const int stripHeight = 220;
const int segmentWidth = stripWidth / segmentCount;

const int startRed = 255;
const int startGreen = 120;
const int startBlue = 40;

const int endRed = 30;
const int endGreen = 110;
const int endBlue = 255;

int frameCount = 0;

while (!QuitRequested())
{
    ProcessEvents();
    ClearScreen(ColorBlack());

    for (int i = 0; i < segmentCount; i++)
    {
        double t = (double)i / (segmentCount - 1);

        // Interpolation formula: value = start + t * (end - start).
        int red = (int)(startRed + t * (endRed - startRed));
        int green = (int)(startGreen + t * (endGreen - startGreen));
        int blue = (int)(startBlue + t * (endBlue - startBlue));

        Color gradientColor = RGBColor(red, green, blue);
        int x = stripX + i * segmentWidth;

        // Draw one gradient bar for this segment.
        DrawRectangle(gradientColor, x, stripY, segmentWidth, stripHeight);

        // Show channel values in the HUD every fourth segment.
        if (i % 4 == 0)
        {
            string label = $"[{i}] R{red} G{green} B{blue}";
            DrawText(label, ColorWhite(), x, stripY + stripHeight + 14);
        }
    }

    int selectedIndex = (frameCount / 20) % segmentCount;
    double selectedT = (double)selectedIndex / (segmentCount - 1);

    int selectedRed = (int)(startRed + selectedT * (endRed - startRed));
    int selectedGreen = (int)(startGreen + selectedT * (endGreen - startGreen));
    int selectedBlue = (int)(startBlue + selectedT * (endBlue - startBlue));

    Color selectedColor = RGBColor(selectedRed, selectedGreen, selectedBlue);
    int selectedX = stripX + selectedIndex * segmentWidth;

    // Highlight one segment and print its RGB channels.
    DrawRectangle(ColorWhite(), selectedX - 2, stripY - 2, segmentWidth + 4, stripHeight + 4);
    DrawRectangle(selectedColor, selectedX, stripY, segmentWidth, stripHeight);

    string formulaText = "value = start + t(end - start)";
    string hudText = $"Segment {selectedIndex} -> R {selectedRed}, G {selectedGreen}, B {selectedBlue}";

    DrawText("Color Workshop - Gradient Composer", ColorWhite(), 40, 36);
    DrawText(formulaText, ColorWhite(), 40, 346);
    DrawText(hudText, ColorWhite(), 40, 378);

    RefreshScreen(60);
    frameCount++;
}

CloseAllWindows();
