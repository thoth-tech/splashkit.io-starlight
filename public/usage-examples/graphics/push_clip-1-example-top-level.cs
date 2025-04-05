using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Push Clip Example", 800, 600);

ClearScreen(ColorWhite());
FillCircle(ColorGoldenrod(), 400, 300, 200);
FillCircle(ColorSwinburneRed(), 400, 300, 180);
RefreshScreen();
Delay(1000);


ClearScreen(ColorWhite());
FillCircle(ColorGoldenrod(), 400, 300, 200);
FillCircle(ColorSwinburneRed(), 400, 300, 180);

Rectangle clipRect = RectangleFrom(400, 95, 205, 410);
DrawRectangle(ColorRoyalBlue(), clipRect);

DrawText("First Clipping Rectangle", ColorBlack(), 100, 550);
RefreshScreen();
Delay(2000);

ClearScreen(ColorWhite());
FillCircle(ColorGoldenrod(), 400, 300, 200);
FillCircle(ColorSwinburneRed(), 400, 300, 180);

Rectangle cornerRect = RectangleFrom(195, 295, 410, 210);
DrawRectangle(ColorRoyalBlue(), cornerRect);

DrawText("Second Clipping Rectangle", ColorBlack(), 100, 550);
RefreshScreen();
Delay(2000);

ClearScreen(ColorWhite());
FillCircle(ColorGoldenrod(), 400, 300, 200);
FillCircle(ColorSwinburneRed(), 400, 300, 180);
RefreshScreen();
Delay(100);

ClearScreen(ColorWhite());
FillCircle(ColorGoldenrod(), 400, 300, 200);
FillCircle(ColorSwinburneRed(), 400, 300, 180);

DrawRectangle(ColorRoyalBlue(), clipRect);
DrawRectangle(ColorRoyalBlue(), cornerRect);

DrawText("Intersection of Both Rectangles", ColorBlack(), 100, 550);
RefreshScreen();
Delay(2000);

PushClip(clipRect);
ClearScreen(ColorWhite());
FillCircle(ColorGoldenrod(), 400, 300, 200);
FillCircle(ColorSwinburneRed(), 400, 300, 180);
PopClip();

DrawText("First Push Clip", ColorBlack(), 100, 550);
RefreshScreen();
Delay(2000);

PushClip(clipRect);
PushClip(cornerRect);
ClearScreen(ColorWhite());
FillCircle(ColorGoldenrod(), 400, 300, 200);
FillCircle(ColorSwinburneRed(), 400, 300, 180);
PopClip();
PopClip();

DrawText("Final Result After Second Push Clip", ColorBlack(), 100, 550);
RefreshScreen();
Delay(4000);
CloseAllWindows();

