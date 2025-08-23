using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Bitmap Center", 800, 600);

Bitmap image_bitmap = LoadBitmap("image_bitmap", "image1.jpg");

ClearScreen(ColorWhite());
DrawBitmap(image_bitmap, 0, 0);
FillCircle(ColorRed(), CircleAt(BitmapCenter(image_bitmap), 5));
RefreshScreen();

Delay(5000);

CloseAllWindows();