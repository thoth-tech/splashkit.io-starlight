using System;
using SplashKitSDK;
using static SplashKitSDK.SplashKit;

//Method to get the maximum length for the circle to still be on screen
int get_val(int rand, int large)
{
    int start;

    if (rand > (large - rand))
    {
        start = large - rand;
    }
    else
    {
        start = rand;
    }

    return start;
}

//Method that retrieves a random circle position
Circle get_circle()
{
    Random rnd = new Random();
    int random_value = rnd.Next(0,300);
    int start_value = get_val(random_value, 600);
    Circle circle = CircleAt(rnd.Next(0 + start_value, 800 - start_value), rnd.Next(start_value, 600 - start_value), random_value);
    return circle;
}


Circle circle_1 = get_circle();

Circle circle_2 = get_circle();


OpenWindow("Circle X", 800, 600);

// Draw the Circle and x coordinate on window
ClearScreen(ColorWhite());
DrawCircle(ColorRed(), circle_1);
DrawCircle(ColorGreen(), circle_2);

//Checks if the circles intersect or not
bool circle_intersect = CirclesIntersect(circle_1, circle_2);
string val = circle_intersect ? "true" : "false";
DrawText("Circle X intersecting with Circle Y is " + val , ColorBlack(), 100, 100);
RefreshScreen();

Delay(4000);
CloseAllWindows();
