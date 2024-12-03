using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Create Window
OpenWindow("Random Quad Shape", 600, 600);
Bitmap Bmp = new Bitmap("Random Quads", 600, 600);

// Create quad using random points on bitmap
Quad Q = QuadFrom(
    RandomBitmapPoint(Bmp),
    RandomBitmapPoint(Bmp),
    RandomBitmapPoint(Bmp),
    RandomBitmapPoint(Bmp));
DrawQuadOnBitmap(Bmp, Color.Black, Q);

ClearScreen(Color.WhiteSmoke);

// Draw the bitmap
DrawBitmap(Bmp, 0, 0);

RefreshScreen();
Delay(5000);
CloseAllWindows();
