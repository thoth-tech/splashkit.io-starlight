using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Center Point", 800, 600);
ClearScreen();

// Set position for the circle
double x_position = 400;
double y_position = 300;

// Create A circle name "A"
Circle A = CircleAt(x_position, y_position, 200);

//Draw the Circle A
DrawCircle(Color.Red, A);
    
//Draw Point in the center of the circle
FillCircle(Color.Black, CenterPoint(A).X, CenterPoint(A).Y, 3);
    
string text = "Center Point At: " + PointToString(CenterPoint(A));
// Print result on window
DrawText(PointToString(CenterPoint(A)), Color.Black, x_position -20, y_position - 20);

RefreshScreen();
Delay(4000);
CloseAllWindows();
     
