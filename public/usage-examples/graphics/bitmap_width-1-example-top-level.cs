using SplashKitSDK;
using static SplashKitSDK.SplashKit;

Bitmap imageBitmap = LoadBitmap("imageBitmap", "image1.jpg");

Window programWindow = OpenWindow("Bitmap Width", BitmapWidth(imageBitmap) + 200, BitmapHeight(imageBitmap) + 200);

ClearScreen(ColorWhite());
DrawBitmap(imageBitmap, (WindowWidth(programWindow) - BitmapWidth(imageBitmap)) / 2, (WindowHeight(programWindow) - BitmapHeight(imageBitmap)) / 2);
DrawText($"The above bitmap is {BitmapWidth(imageBitmap)} pixels in width", ColorBlack(), (WindowWidth(programWindow) - BitmapWidth(imageBitmap)) / 2, WindowHeight(programWindow) - 70);
RefreshScreen();

Delay(5000);

CloseAllWindows();