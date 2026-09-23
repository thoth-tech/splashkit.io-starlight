using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Take Screenshot", 800, 600);

double rotation = 0;
int opacityValue = 0;
int randColorCounter = 0;
Color randColor = RandomColor();
Bitmap imageBitmap = LoadBitmap("image_bitmap", "image1.jpg");

while (!QuitRequested())
{
    rotation += 0.01;
    randColorCounter += 1;

    if (opacityValue != 0)
    {
        opacityValue -= 1;
    }

    if (randColorCounter >= 3000)
    {
        randColor = RandomColor();
        randColorCounter = 0;
    }

    ProcessEvents();

    if (KeyTyped(KeyCode.ReturnKey))
    {
        // Function used here ↓
        TakeScreenshot("saved_screenshot");
        opacityValue = 2500;
    }

    ClearScreen(ColorWhite());
    FillRectangle(randColor, RectangleFrom(450, 200, 150, 150));
    DrawBitmap(imageBitmap, 100, 100, OptionRotateBmp(rotation));
    DrawText("Press the 'Enter' key to take a screenshot of the game window", ColorBlack(), 175, 450);
    DrawText("Image saved to desktop!", RGBAColor(0, 0, 0, opacityValue), 310, 470);
    RefreshScreen();
}
CloseAllWindows();