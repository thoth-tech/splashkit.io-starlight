using SplashKitSDK;
using static SplashKitSDK.SplashKit;

//  Variable Declerations
Point2D point_1 = PointAt(50,75);
Point2D point_2;
string guess;
List<string> coords;


WriteLine("Guess the coordinate inside (100,100) ");


while (true)
{
    // Get user input
    Write("Enter your coordinates as x,y: ");
    guess = ReadLine();
    coords = Split(guess,',');
    
    // convert input 
    point_2 = PointAt(ConvertToDouble(coords[0]),ConvertToDouble(coords[1]));
    
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