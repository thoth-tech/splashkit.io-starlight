using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Image Flipping Simulator", 800, 600);

int opacityValue = 255;
string displayedText = "This bitmap is not flipped along its X axis";
bool flipped = false;
Bitmap imageBitmap = LoadBitmap("imageBitmap", "image1.jpg");

while (!QuitRequested())
{
    ProcessEvents();
    if (Button("Click to invert X axis", RectangleFrom(320, 450, 160, 30)) && flipped == false)
    {
        opacityValue = 0;
        displayedText = "This bitmap has been flipped along its X axis";
        flipped = true;
    }
    else if (Button("Click to invert X axis", RectangleFrom(320, 450, 160, 30)) && flipped == true)
    {
        opacityValue = 0;
        displayedText = "This bitmap is not flipped along its X axis";
        flipped = false;
    }

    if (opacityValue != 255)
    {
        opacityValue += 1;
    }

    ClearScreen();
    if (flipped == false)
    {
        DrawBitmap(imageBitmap, 200, 155);
    }
    else
    {
        DrawBitmap(imageBitmap, 200, 155, OptionFlipX());
    }
    DrawText(displayedText, RGBAColor(0, 0, 0, opacityValue), 200, 100);
    DrawInterface();

    RefreshScreen();
}
CloseAllWindows();