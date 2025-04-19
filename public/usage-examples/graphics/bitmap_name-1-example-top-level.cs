using SplashKitSDK;

Bitmap myImage = SplashKit.LoadBitmap("logo", "splashkit.png");
string name = SplashKit.BitmapName(myImage);

SplashKit.OpenWindow("Bitmap Name Example", 800, 600);

// Center the image in the window
float x = (800 - SplashKit.BitmapWidth(myImage)) / 2;
float y = (600 - SplashKit.BitmapHeight(myImage)) / 2;

SplashKit.DrawBitmap(myImage, x, y);
SplashKit.RefreshScreen();

SplashKit.WriteLine("Bitmap name: " + name);
SplashKit.Delay(3000);