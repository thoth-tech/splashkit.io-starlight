using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Circle At", 800, 600);
ClearScreen();

// Set position for the circle
double x_position = 400;
double y_position = 300;

// Create A circle name "A"
Circle A = CircleAt(x_position, y_position, 200);

//Draw the Circle
DrawCircle(Color.Red, x_position, y_position, 200);
    
string text = "Circle At: (400,300), Radius: 200";
// Print result on window
DrawText(text, Color.Black, "NORMAL_FONT", 20, 100, 100);

RefreshScreen();
Delay(4000);
CloseAllWindows();
     
