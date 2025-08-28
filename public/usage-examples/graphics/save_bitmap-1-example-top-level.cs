using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Save Bitmap", 800, 600);

int opacityValue = 0;
Bitmap imageBitmap = LoadBitmap("imageBitmap", "image1.jpg");

while (!QuitRequested())
{
    ProcessEvents();
    if (KeyTyped(KeyCode.ReturnKey))
    {
        SaveBitmap(imageBitmap, "savedBitmap");
        opacityValue = 2500;
    }

    if (opacityValue != 0)
    {
        opacityValue -= 1;
    }

    ClearScreen(ColorWhite());
    DrawBitmap(imageBitmap, 200, 155);
    DrawText("Press the 'Enter' key to save the above bitmap to desktop", ColorBlack(), 175, 450);
    DrawText("Image saved to desktop!", RGBAColor(0, 0, 0, opacityValue), 310, 470);

    RefreshScreen();
}
CloseAllWindows();