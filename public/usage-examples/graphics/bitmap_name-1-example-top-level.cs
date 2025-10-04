using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Bitmap Name", 800, 600);

Bitmap imageBitmap = LoadBitmap("insert_name_here", "image1.jpg");

ClearScreen(ColorWhite());
DrawBitmap(imageBitmap, 200, 155);
DrawText("The name of the above bitmap is '" + BitmapName(imageBitmap) + "'", ColorBlack(), 215, 450);
RefreshScreen();

Delay(5000);

CloseAllWindows();