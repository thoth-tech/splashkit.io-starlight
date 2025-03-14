using System;
using SplashKitSDK;


namespace OOP
{
    public class Program
    {
        //Method to get the maximum length for the circle to still be on screen
        static int get_val(int rand, int large)
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
        static Circle get_circle()
        {
            Random rnd = new Random();
            int random_value = rnd.Next(0,300);
            int start_value = get_val(random_value, 600);
            Circle circle = SplashKit.CircleAt(rnd.Next(0 + start_value, 800 - start_value), rnd.Next(start_value, 600 - start_value), random_value);
            return circle;
        }

        public static void Main()
        {
            Circle circle_1 = get_circle();

            Circle circle_2 = get_circle();


            SplashKit.OpenWindow("Circle X", 800, 600);

            // Draw the Circle and x coordinate on window
            SplashKit.ClearScreen(SplashKit.ColorWhite());
            SplashKit.DrawCircle(SplashKit.ColorRed(), circle_1);
            SplashKit.DrawCircle(SplashKit.ColorGreen(), circle_2);

            //Checks if the circles intersect or not
            bool circle_intersect = SplashKit.CirclesIntersect(circle_1, circle_2);
            string val = circle_intersect ? "true" : "false";
            SplashKit.DrawText("Circle X intersecting with Circle Y is " + val , SplashKit.ColorBlack(), 100, 100);
            SplashKit.RefreshScreen();

            SplashKit.Delay(4000);
            SplashKit.CloseAllWindows();
        }
    }
}