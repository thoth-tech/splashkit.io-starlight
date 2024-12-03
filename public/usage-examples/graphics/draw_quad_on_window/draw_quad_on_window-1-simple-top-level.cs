using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Initialise quads with x1, y1, ..., x4, y4
Quad Q1 = QuadFrom(400, 200, 300, 300, 300, 0, 200, 200);
Quad Q2 = QuadFrom(400, 210, 310, 300, 600, 300, 400, 390);
Quad Q3 = QuadFrom(200, 400, 300, 300, 300, 600, 400, 400);
Quad Q4 = QuadFrom(200, 390, 290, 300, 0, 300, 200, 210);

// Create Windows
Window Window1 = OpenWindow("Diamonds On Window 1", 600, 600);
Window Window2 = OpenWindow("Diamonds On Window 2", 600, 600);
ClearScreen(ColorWhite());

// Draw quads on each window
DrawQuadOnWindow(Window1, ColorBlack(), Q1);
DrawQuadOnWindow(Window1, ColorGreen(), Q2);
DrawQuadOnWindow(Window2, ColorRed(), Q3);
DrawQuadOnWindow(Window2, ColorBlue(), Q4);

RefreshScreen();
Delay(5000);
CloseAllWindows();