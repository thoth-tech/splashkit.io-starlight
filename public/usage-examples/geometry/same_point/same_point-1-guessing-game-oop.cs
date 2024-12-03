using SplashKitSDK;

namespace SamePoint
{
    public class Program
    {
        public static void Main()
        {
            // Variable Declarations
            Point2D Point1 = SplashKit.PointAt(50, 75);
            Point2D Point2;
            string GuessInput;
            List<string> Coords;
            double GuessX;
            double GuessY;
            bool Guess = false;

            SplashKit.WriteLine("Guess the coordinate inside (100,100) ");

            while (!Guess)
            {
                // Get user input
                SplashKit.Write("Enter your coordinates as x,y: ");
                GuessInput = SplashKit.ReadLine();
                Coords = SplashKit.Split(GuessInput, ',');

                // Convert input
                GuessX = SplashKit.ConvertToDouble(Coords[0]);
                GuessY = SplashKit.ConvertToDouble(Coords[1]);
                Point2.X = GuessX;
                Point2.Y = GuessY;

                // Clues
                if (Point1.X > GuessX)
                    SplashKit.WriteLine("x is too low");
                else if (Point1.X < GuessX)
                    SplashKit.WriteLine("x is too high");
                else
                    SplashKit.WriteLine("x is correct !!!");

                if (Point1.Y > GuessY)
                    SplashKit.WriteLine("y is too low");
                else if (Point1.Y < GuessY)
                    SplashKit.WriteLine("y is too high");
                else
                    SplashKit.WriteLine("y is correct !!!");

                // Point Comparison
                Guess = SplashKit.SamePoint(Point1, Point2);
                if (!Guess)
                {
                    SplashKit.WriteLine("Try Again!");
                }
                else
                {
                    SplashKit.WriteLine("You Win!");
                }
            }
        }
    }
}