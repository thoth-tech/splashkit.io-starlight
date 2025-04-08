using static SplashKitSDK.SplashKit;

Window window = new Window("Pop Clip", 400, 400);

SetClip(200, 200, 200, 200);
FillRectangle(Color.Red, 200, 200, 100, 100);

PopClip();
FillRectangle(Color.Green, 100, 150, 100, 100);

RefreshScreen();
Delay(5000);
