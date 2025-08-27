using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Option Rotate Bmp", 800, 600);

Bitmap imageBitmap = LoadBitmap("image_bitmap", "image1.jpg");

ClearScreen(ColorWhite());
// Function used here ↓
DrawBitmap(imageBitmap, 200, 130, OptionRotateBmp(10));
DrawText("This bitmap has been rotated by +10 degrees", ColorBlack(), 215, 450);
RefreshScreen();

Delay(5000);

CloseAllWindows();