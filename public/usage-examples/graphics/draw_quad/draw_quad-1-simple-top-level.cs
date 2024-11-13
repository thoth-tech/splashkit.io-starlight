using SplashKitSDK;
using static SplashKitSDK.SplashKit;


//Initialise quads with x1,y1,...,x4,y4
Quad q1 = QuadFrom(400,200,300,300,300,0,200,200);   
Quad q2 = QuadFrom(400,210,310, 300,600,300,400,390);
Quad q3 = QuadFrom(200,400,300, 300,300,600,400,400);
Quad q4 = QuadFrom(200,390,290, 300,0,300,200,210);   


// Create Window

OpenWindow("Draw Quad", 600, 600);
ClearScreen(ColorWhite());


DrawQuad(ColorBlack(), q1);
DrawQuad(ColorGreen(), q2);
DrawQuad(ColorRed(), q3);
DrawQuad(ColorBlue(), q4);

RefreshScreen();
Delay(5000);
CloseAllWindows();
