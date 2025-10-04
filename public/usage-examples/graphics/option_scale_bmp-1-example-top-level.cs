using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Option Scale Bmp", 800, 600);

Bitmap imageBitmap = LoadBitmap("image_bitmap", "image1.jpg");

ClearScreen(ColorWhite());
// Function used here ↓
DrawBitmap(imageBitmap, 200, 130, OptionScaleBmp(1.5, 1.5));
DrawText("This bitmap has been made 50 percent larger than normal", ColorBlack(), 180, 470);
RefreshScreen();

Delay(5000);

CloseAllWindows();