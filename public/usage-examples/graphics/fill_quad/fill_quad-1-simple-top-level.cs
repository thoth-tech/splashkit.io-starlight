using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Initialise quads with x1, y1, ..., x4, y4
Quad Q1 = QuadFrom(400, 200, 300, 300, 300, 0, 200, 200);
Quad Q2 = QuadFrom(400, 210, 310, 300, 600, 300, 400, 390);
Quad Q3 = QuadFrom(200, 400, 300, 300, 300, 600, 400, 400);
Quad Q4 = QuadFrom(200, 390, 290, 300, 0, 300, 200, 210);

// Create Window
OpenWindow("Coloured Star", 600, 600);
ClearScreen(ColorWhite());

FillQuad(ColorBlack(), Q1);
FillQuad(ColorGreen(), Q2);
FillQuad(ColorRed(), Q3);
FillQuad(ColorBlue(), Q4);

RefreshScreen();
Delay(5000);
CloseAllWindows();
