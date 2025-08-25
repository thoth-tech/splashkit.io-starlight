using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Bitmap Width", 800, 600);

Bitmap imageBitmap = LoadBitmap("imageBitmap", "image1.jpg");

ClearScreen(ColorWhite());
DrawBitmap(imageBitmap, 200, 155);
DrawText($"The above bitmap is {BitmapWidth(imageBitmap)} pixels in width", ColorBlack(), 215, 450);
RefreshScreen();

Delay(5000);

CloseAllWindows();