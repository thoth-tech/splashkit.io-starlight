using SplashKitSDK;
using static SplashKitSDK.SplashKit;

//  Variable Declerations
Point2D point_1 = PointAt(50,75);
Point2D point_2;
string guess;
List<string> coords;
double guess_x;
double guess_y;

WriteLine("Guess the coordinate inside (100,100) ");


while (true)
{
    // Get user input
    Write("Enter your coordinates as x,y: ");
    guess = ReadLine();
    coords = Split(guess,',');
    guess_x = ConvertToDouble(coords[0]);
    guess_y = ConvertToDouble(coords[1]);

    // convert input 
    point_2 = PointAt(guess_x,guess_y);
    
    //clues
    if (point_1.X > guess_x) 
        WriteLine("x is to low");
    else if (point_1.X < guess_x) 
        WriteLine("x is to high");
    else 
        WriteLine("x is correct !!!");
    
    if (point_1.Y > guess_y) 
        WriteLine("y is to low");
    else if (point_1.Y < guess_y) 
        WriteLine("y is to high");
    else 
        WriteLine("y is correct !!!");

    // Point Comparison 
    if(!SamePoint(point_1,point_2))
    {
        WriteLine("Try Again!");
    } 
    else 
    {
        WriteLine("You Win!");
        break;
    }
}