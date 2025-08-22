using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Bitmap Bounding Rectangle", 800, 600);

int refreshCounter = 0;
Point2D verticalBitmapPos = PointAt(0, 0);
Point2D horizontalBitmapPos = PointAt(0, 0);
Rectangle bitmapRectangle = RectangleFrom(0, 0, 0, 0); ;
Bitmap verticalBitmap = LoadBitmap("verticalBitmap", "image1.jpeg");
Bitmap horizontalBitmap = LoadBitmap("horizontalBitmap", "image2.png");

while (!QuitRequested())
{
    ProcessEvents();

    refreshCounter += 1;
    if (refreshCounter <= 15000)
    {
        //Function used here ↓
        bitmapRectangle = BitmapBoundingRectangle(verticalBitmap);
        verticalBitmapPos = PointAt(200, 120);
        horizontalBitmapPos = PointAt(1000, 1000);
        bitmapRectangle.X = 450;
        bitmapRectangle.Y = 120;
    }
    else if (refreshCounter > 15000 && refreshCounter <= 30000)
    {
        //Function used here ↓
        bitmapRectangle = BitmapBoundingRectangle(horizontalBitmap);
        verticalBitmapPos = PointAt(1000, 1000);
        horizontalBitmapPos = PointAt(150, 243);
        bitmapRectangle.X = 450;
        bitmapRectangle.Y = 243;
    }
    else
    {
        refreshCounter = 0;
    }

    ClearScreen(ColorWhite());

    DrawRectangle(ColorBlack(), bitmapRectangle);
    DrawBitmap(verticalBitmap, verticalBitmapPos.X, verticalBitmapPos.Y);
    DrawBitmap(horizontalBitmap, horizontalBitmapPos.X, horizontalBitmapPos.Y);

    RefreshScreen();
}
CloseAllWindows();