using SplashKitSDK;


namespace SamePoint
{
    public class Program
    {
        public static void Main()
        {
            //  Variable Declerations
            Point2D point_1 = SplashKit.PointAt(50,75);
            Point2D point_2;
            string guess;
            List<string> coords;
            double guess_x;
            double guess_y;


            SplashKit.WriteLine("Guess the coordinate inside (100,100) ");


            while (true)
            {
                // Get user input
                SplashKit.Write("Enter your coordinates as x,y: ");
                guess = SplashKit.ReadLine();
                coords = SplashKit.Split(guess,',');
                guess_x = SplashKit.ConvertToDouble(coords[0]);
                guess_y = SplashKit.ConvertToDouble(coords[1]);

                // convert input 
                point_2 = SplashKit.PointAt(guess_x,guess_y);
                
                //clues
                if (point_1.X > guess_x) 
                    SplashKit.WriteLine("x is to low");
                else if (point_1.X < guess_x) 
                    SplashKit.WriteLine("x is to high");
                else 
                    SplashKit.WriteLine("x is correct !!!");
                
                if (point_1.Y > guess_y) 
                    SplashKit.WriteLine("y is to low");
                else if (point_1.Y < guess_y) 
                    SplashKit.WriteLine("y is to high");
                else 
                    SplashKit.WriteLine("y is correct !!!");

                // Point Comparison 
                if(!SplashKit.SamePoint(point_1,point_2))
                {
                    SplashKit.WriteLine("Try Again!");
                } 
                else 
                {
                    SplashKit.WriteLine("You Win!");
                    break;
                }
            }
        }       
    }
}