using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Bitmap Bounding Rectangle", 800, 600);

Bitmap vertical_bitmap = LoadBitmap("vertical_bitmap", "image1.jpeg");
Bitmap horizontal_bitmap = LoadBitmap("horizontal_bitmap", "image2.png");
// Function used here ↓
Rectangle vertical_rectangle = BitmapBoundingRectangle(vertical_bitmap);
Rectangle horizontal_rectangle = BitmapBoundingRectangle(horizontal_bitmap);

vertical_rectangle.X = 212;
vertical_rectangle.Y = 50;
horizontal_rectangle.X = 150;
horizontal_rectangle.Y = 400;

ProcessEvents();

ClearScreen(ColorWhite());
DrawBitmap(vertical_bitmap, 450, 50);
DrawRectangle(ColorBlack(), vertical_rectangle);
DrawBitmap(horizontal_bitmap, 450, 400);
DrawRectangle(ColorBlack(), horizontal_rectangle);
RefreshScreen();

Delay(5000);

CloseAllWindows();