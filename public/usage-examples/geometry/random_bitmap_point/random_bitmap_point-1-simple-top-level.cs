using SplashKitSDK;
using static SplashKitSDK.SplashKit;

//Create Window
OpenWindow("random bitmap point", 600, 600);
Bitmap bmp = new Bitmap("random quads",600,600);

// create quad using random points on bitmap
Quad q = QuadFrom(
    RandomBitmapPoint(bmp),
    RandomBitmapPoint(bmp),
    RandomBitmapPoint(bmp),
    RandomBitmapPoint(bmp));
DrawQuadOnBitmap(bmp, Color.Black, q);

ClearScreen(Color.WhiteSmoke);

//Draw the bitmap
DrawBitmap(bmp, 0,0);

RefreshScreen();
Delay(5000);
CloseAllWindows();