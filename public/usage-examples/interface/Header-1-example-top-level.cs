using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Constants for window and UI elements
const int windowWidth = 600;
const int windowHeight = 400;
const int headerHeight = 80;
const int buttonWidth = 160;
const int buttonHeight = 50;

// Calculate horizontal center position for text
float CalculateCenterX(string text, string fontName, int fontSize, float areaWidth)
{
    Font loadedFont = LoadFont(fontName, $"{fontName}.ttf");
    int textWidthPx = TextWidth(text, loadedFont, fontSize);
    return (areaWidth - textWidthPx) / 2.0f;
}

// Open the window
Window uiWindow = OpenWindow("Header Interactive Example", windowWidth, windowHeight);
LoadFont("Arial", "Arial.ttf");

string displayMessage = "Click the button!";

while (!uiWindow.CloseRequested)
{
    ProcessEvents();
    ClearScreen(Color.White);

    // Draw header section background
    FillRectangle(Color.DarkOrange, 0, 0, windowWidth, headerHeight);

    // Centered header text
    float headerX = CalculateCenterX("Welcome to SplashKit UI", "Arial", 24, windowWidth);
    DrawText("Welcome to SplashKit", Color.White, "Arial", 24, headerX, 25);

    // Draw separator line below header
    DrawLine(Color.Black, 0, headerHeight, windowWidth, headerHeight);

    // Display centered message text
    float messageX = CalculateCenterX(displayMessage, "Arial", 20, windowWidth);
    DrawText(displayMessage, Color.Black, "Arial", 20, messageX, 120);

    // Draw centered button
    int buttonX = (windowWidth - buttonWidth) / 2;
    int buttonY = 180;
    FillRectangle(Color.DarkTurquoise, buttonX, buttonY, buttonWidth, buttonHeight);

    float buttonTextX = CalculateCenterX("Click Me!", "Arial", 20, windowWidth);
    DrawText("Click Me!", Color.White, "Arial", 20, buttonTextX, buttonY + 15);

    // Handle mouse click events for the button
    if (MouseClicked(MouseButton.LeftButton))
    {
        Point2D mousePos = MousePosition();

        if (mousePos.X >= buttonX && mousePos.X <= buttonX + buttonWidth &&
            mousePos.Y >= buttonY && mousePos.Y <= buttonY + buttonHeight)
        {
            displayMessage = "Button Clicked!";
        }
    }

    RefreshScreen(60);
}

CloseAllWindows();
