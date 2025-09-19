using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Option Rotate Bmp", 800, 600);

Bitmap imageBitmap = LoadBitmap("image_bitmap", "image1.jpg");
int bitmap_rotation = 10;

ClearScreen(ColorWhite());
DrawBitmap(imageBitmap, 200, 130, OptionRotateBmp(bitmap_rotation));
DrawText("This bitmap has been rotated by " + bitmap_rotation.ToString() + " degrees", ColorBlack(), 215, 450);
RefreshScreen();

Delay(5000);

CloseAllWindows();