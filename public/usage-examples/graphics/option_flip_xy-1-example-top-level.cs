using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Option Flip Xy", 800, 600);

Bitmap imageBitmap = LoadBitmap("image_bitmap", "image1.jpg");

ClearScreen(ColorWhite());
// Function used here ↓
DrawBitmap(imageBitmap, 200, 155, OptionFlipXy());
DrawText("This bitmap has been flipped along it's X and Y axes", ColorBlack(), 215, 450);
RefreshScreen();

Delay(5000);

CloseAllWindows();