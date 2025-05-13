using SplashKitSDK;
using static SplashKitSDK.SplashKit;

public class Program
{
    public static void Main()
    {
        const int windowWidth = 600;
        const int windowHeight = 400;
        const int headerHeight = 80;
        const int buttonWidth = 160;
        const int buttonHeight = 50;

        Window window = new Window("SplashKit Header UI", windowWidth, windowHeight);
        LoadFont("Arial", "Arial.ttf");

        string displayMessage = "Click the button!";

        while (!window.CloseRequested)
        {
            ProcessEvents();
            ClearScreen(Color.White);

            // Draw header background and text
            FillRectangle(Color.DarkOrange, 0, 0, windowWidth, headerHeight);
            DrawCenteredText("Welcome to SplashKit", "Arial", 24, Color.White, windowWidth, 25);
            DrawLine(Color.Black, 0, headerHeight, windowWidth, headerHeight);

            // Draw message text
            DrawCenteredText(displayMessage, "Arial", 20, Color.Black, windowWidth, 120);

            // Draw button
            int buttonX = (windowWidth - buttonWidth) / 2;
            int buttonY = 180;
            FillRectangle(Color.DarkTurquoise, buttonX, buttonY, buttonWidth, buttonHeight);
            DrawCenteredText("Click Me!", "Arial", 20, Color.White, windowWidth, buttonY + 15);

            // Check for button click
            if (MouseClicked(MouseButton.LeftButton))
            {
                Point2D mouse = MousePosition();

                if (mouse.X >= buttonX && mouse.X <= buttonX + buttonWidth &&
                    mouse.Y >= buttonY && mouse.Y <= buttonY + buttonHeight)
                {
                    displayMessage = "Button Clicked!";
                }
            }

            RefreshScreen(60);
        }

        CloseAllWindows();
    }

    public static void DrawCenteredText(string text, string fontName, int fontSize, Color color, int areaWidth, int y)
    {
        Font font = LoadFont(fontName, $"{fontName}.ttf");
        int textWidth = TextWidth(text, font, fontSize);
        float x = (areaWidth - textWidth) / 2.0f;
        DrawText(text, color, fontName, fontSize, x, y);
    }
}
