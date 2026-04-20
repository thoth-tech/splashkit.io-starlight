using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Bitmap Height", 800, 600);

Bitmap imageBitmap = LoadBitmap("imageBitmap", "image1.jpg");

ClearScreen(ColorWhite());
DrawBitmap(imageBitmap, 200, 155);
DrawText($"The above bitmap is {BitmapHeight(imageBitmap)} pixels in height", ColorBlack(), 215, 450);
RefreshScreen();

Delay(5000);

CloseAllWindows();