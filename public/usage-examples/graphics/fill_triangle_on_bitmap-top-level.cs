using SplashKitSDK;

Bitmap triangleBmp = new Bitmap("triangle", 618, 618);
triangleBmp.Clear(Color.White);

// Triangle coordinates
float x1 = 100, y1 = 200;
float x2 = 309, y2 = 20;
float x3 = 520, y3 = 200;

// Draw the triangle
triangleBmp.FillTriangle(Color.Red, x1, y1, x2, y2, x3, y3);

// Display it in a window
Window window = new Window("Fill Triangle on Bitmap", 618, 618);
window.DrawBitmap(triangleBmp, 0, 0);
window.Refresh();

SplashKit.Delay(5000);
