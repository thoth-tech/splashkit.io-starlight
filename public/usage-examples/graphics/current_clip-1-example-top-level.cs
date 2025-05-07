using static SplashKitSDK.SplashKit;

var window = new Window("Current Clip Example", 400, 400);

//Clip the window to a 200×200 region at (100,100)
SetClip(100, 100, 200, 200);

//Fill that region with red (with a rectangle)
FillRectangle(Color.Red, 100, 100, 200, 200);

//Retrieve the clip bounds
var clip = CurrentClip();

//Exit out of the clip
PopClip();

//Outline the old clip in green as a rectangle
DrawRectangle(Color.Green, clip.X, clip.Y, clip.Width, clip.Height);

RefreshScreen();
Delay(5000);
