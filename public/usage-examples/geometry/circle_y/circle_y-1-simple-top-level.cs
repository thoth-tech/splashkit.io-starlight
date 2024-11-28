using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Circle Y", 800, 600);
ClearScreen();

Random random = new Random();
// Set position for the circle
double x_position = 400;
//Give random  y_position value bewteen 200 - 400
double y_position = random.Next(200) + 200;

// Create A circle name "A"
Circle A = CircleAt(x_position, y_position, 200);
// Find the y position of the circle
double circleY = CircleY(A);

//Draw the Circle
DrawCircle(Color.Red, x_position, circleY, 200);
    
string text = "Circle Y: " + circleY.ToString();
// Print result on window
DrawText(text, Color.Black, "NORMAL_FONT", 20, 100, 100);

RefreshScreen();
Delay(4000);
CloseAllWindows();
     
