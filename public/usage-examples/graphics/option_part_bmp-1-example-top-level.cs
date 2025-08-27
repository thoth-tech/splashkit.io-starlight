using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Option Part Bmp", 800, 600);

Bitmap imageBitmap = LoadBitmap("image_bitmap", "image1.jpg");

ClearScreen(ColorWhite());
// Function used here ↓
DrawBitmap(imageBitmap, 200, 155, OptionPartBmp(0, 0, 200, 249));
DrawText("A portion of this bitmap has been drawn", ColorBlack(), 215, 450);
DrawText("In this case, exactly half of it width-wise", ColorBlack(), 214, 465);
RefreshScreen();

Delay(5000);

CloseAllWindows();