using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Push Clip Example", 800, 600);

//Define clipping rectangles to be used later for push_clip
Rectangle clipRect = RectangleFrom(400, 95, 205, 410);
Rectangle cornerRect = RectangleFrom(195, 295, 410, 210);

//Draw our pie we are slicing with clipping rectangles
ClearScreen(ColorWhite());
FillCircle(ColorGoldenrod(), 400, 300, 200);
FillCircle(ColorSwinburneRed(), 400, 300, 180);
RefreshScreen();
Delay(1000);

//Redraw our pie with demonstration of where clipRect will cut
ClearScreen(ColorWhite());
FillCircle(ColorGoldenrod(), 400, 300, 200);
FillCircle(ColorSwinburneRed(), 400, 300, 180);
DrawRectangle(ColorRoyalBlue(), clipRect);
DrawText("First Clipping Rectangle", ColorBlack(), 100, 550);
RefreshScreen();
Delay(2000);

//Redraw our pie with demonstration of where cornerRect will cut
ClearScreen(ColorWhite());
FillCircle(ColorGoldenrod(), 400, 300, 200);
FillCircle(ColorSwinburneRed(), 400, 300, 180);
DrawRectangle(ColorRoyalBlue(), cornerRect);
DrawText("Second Clipping Rectangle", ColorBlack(), 100, 550);
RefreshScreen();
Delay(2000);

//Short Intermediate frame of just pie before showing intersection
ClearScreen(ColorWhite());
FillCircle(ColorGoldenrod(), 400, 300, 200);
FillCircle(ColorSwinburneRed(), 400, 300, 180);
RefreshScreen();
Delay(100);

//Redraw our pie with both rectangles shown to visualize intersection
ClearScreen(ColorWhite());
FillCircle(ColorGoldenrod(), 400, 300, 200);
FillCircle(ColorSwinburneRed(), 400, 300, 180);
DrawRectangle(ColorRoyalBlue(), clipRect);
DrawRectangle(ColorRoyalBlue(), cornerRect);
DrawText("Intersection of Both Rectangles", ColorBlack(), 100, 550);
RefreshScreen();
Delay(2000);

//Pushed first rectangle and redraw the pie
PushClip(clipRect);
ClearScreen(ColorWhite());
FillCircle(ColorGoldenrod(), 400, 300, 200);
FillCircle(ColorSwinburneRed(), 400, 300, 180);
//Popped the rectangle so we can now draw our text without interferance
PopClip();
DrawText("First Push Clip", ColorBlack(), 100, 550);
RefreshScreen();
Delay(2000);

//Pushed both rectangles and redraw the pie
PushClip(clipRect);
PushClip(cornerRect);
ClearScreen(ColorWhite());
FillCircle(ColorGoldenrod(), 400, 300, 200);
FillCircle(ColorSwinburneRed(), 400, 300, 180);
//Popped both rectangle so we can now draw our text without interferance
PopClip();
PopClip();
DrawText("Final Result After Second Push Clip", ColorBlack(), 100, 550);
RefreshScreen();
Delay(4000);

CloseAllWindows();

