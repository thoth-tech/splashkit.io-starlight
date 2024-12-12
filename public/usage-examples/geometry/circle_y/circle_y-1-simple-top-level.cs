using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Circle Y", 800, 600);
ClearScreen();

//Set position for the circle
double x_position = 400;
//Give random  y_position value bewteen 200 - 400
double y_position = Rnd(200) + 200;

//Create a circle A at the position (x_position, y_position)
Circle A = CircleAt(x_position, y_position, 200);
//Find the y position of the circle
double circleY = CircleY(A);

//Draw the Circle
DrawCircle(Color.Red, x_position, circleY, 200);

DrawLine(Color.Black, 0, circleY, 800, circleY);

string text = "Circle Y: " + circleY.ToString();
// Print result on window
DrawText(text, Color.Black, 100, 100);

//Draw 10 circle with radient 50 and the same circle y coordinate
for (int i = 0; i < 10; i++)
{
    int x = i * 60 + 100;
    int radiant = 50;

    DrawCircle(Color.Blue, x, circleY, radiant);
}

RefreshScreen();
Delay(4000);
CloseAllWindows();

