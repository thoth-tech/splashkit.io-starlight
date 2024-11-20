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


            SplashKit.WriteLine("Guess the coordinate inside (100,100) ");


            while (true)
            {
                // Get user input
                SplashKit.Write("Enter your coordinates as x,y: ");
                guess = SplashKit.ReadLine();
                coords = SplashKit.Split(guess,',');
                
                // convert input 
                point_2 = SplashKit.PointAt(SplashKit.ConvertToDouble(coords[0]),SplashKit.ConvertToDouble(coords[1]));
                
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