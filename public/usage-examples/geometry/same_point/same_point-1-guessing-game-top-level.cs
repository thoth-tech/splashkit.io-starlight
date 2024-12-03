using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Variable Declarations
Point2D Point1 = PointAt(50, 75);
Point2D Point2;
string GuessInput;
List<string> Coords;
double GuessX;
double GuessY;
bool Guess = false;

WriteLine("Guess the coordinate inside (100,100) ");

while (!Guess)
{
    // Get user input
    Write("Enter your coordinates as x,y: ");
    GuessInput = ReadLine();
    Coords = Split(GuessInput, ',');

    // Convert input
    GuessX = ConvertToDouble(Coords[0]);
    GuessY = ConvertToDouble(Coords[1]);
    Point2 = PointAt(GuessX, GuessY);

    // Clues
    if (Point1.X > GuessX)
        WriteLine("x is too low");
    else if (Point1.X < GuessX)
        WriteLine("x is too high");
    else
        WriteLine("x is correct !!!");

    if (Point1.Y > GuessY)
        WriteLine("y is too low");
    else if (Point1.Y < GuessY)
        WriteLine("y is too high");
    else
        WriteLine("y is correct !!!");

    // Point Comparison
    Guess = SamePoint(Point1, Point2);
    if (!Guess)
    {
        WriteLine("Try Again!");
    }
    else
    {
        WriteLine("You Win!");
    }
}
