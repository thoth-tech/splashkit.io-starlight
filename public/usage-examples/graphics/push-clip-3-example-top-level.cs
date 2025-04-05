using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Push Clip Example", 800, 600);

var clipRect = RectangleFrom(400, 100, 200, 400);
PushClip(clipRect);

var cornerClipRect = RectangleFrom(200, 300, 400, 200);
PushClip(cornerClipRect);

ClearScreen(Color.White);
FillCircle(Color.Red, 400, 300, 200);
RefreshScreen();

Delay(4000);

CloseAllWindows();

