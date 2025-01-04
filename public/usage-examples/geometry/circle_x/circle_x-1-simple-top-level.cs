using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Circle X", 800, 600);
ClearScreen();

Random random = new Random();
// Set position for the circle
// Give random  x_position value bewteen 200 - 600
double x_position = random.Next(400) + 200;
double y_position = 300;

// Create A circle name "A" at the position (x_position, y_position)
Circle A = CircleAt(x_position, y_position, 200);
// Find the x position of the circle
double circleX = CircleX(A);

//Draw the Circle
DrawCircle(Color.Red, circleX, y_position, 200);
    
string text = "Circle X: " + circleX.ToString();
// Print result on window
DrawText(text, Color.Black, "NORMAL_FONT", 20, 100, 100);

RefreshScreen();
Delay(4000);
CloseAllWindows();
     
