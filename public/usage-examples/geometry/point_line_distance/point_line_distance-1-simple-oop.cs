using SplashKitSDK;

namespace PointLineDistance
{
    public class Program 
    {
        public static void Main()
        {
             // Open a new window
            Window wnd = SplashKit.OpenWindow("Line Game", 800, 600);

            // Define start and end points of line
            Point2D pnt1 = SplashKit.PointAt(0, 400);
            Point2D pnt2 = SplashKit.PointAt(800, 400);

             // Create a line 
            Line lne = SplashKit.LineFrom(pnt1, pnt2);
            SplashKit.ClearScreen();

            // Draw the line to make it visible
            SplashKit.DrawLineOnWindow(wnd, Color.Black, lne);

            // Draw circles to indicate start and finish 
            SplashKit.FillCircleOnWindow(wnd, Color.Green, 15, 400, 3);
            SplashKit.FillCircleOnWindow(wnd,Color.Red, 785, 400, 3);

             // Load font and draw instructions text
            Font font1 = SplashKit.LoadFont("NunitoSans", "NunitoSans.ttf");
            SplashKit.DrawTextOnWindow(wnd, "Put your cursor on the line and move from the green to red dot without straying from the line", Color.Black, font1, 14, 100, 200);
            SplashKit.RefreshScreen();
            SplashKit.Delay(3000); // Wait 3 seconds

             // While window is open 
            while(!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                 // Define user's mouse position 
                Point2D user = SplashKit.MousePosition();

                 // Get distance between cursor and line 
                float distance = SplashKit.PointLineDistance(user, lne);

                 // Print to terminal
                SplashKit.WriteLine(distance);
                SplashKit.Delay(300);

                // If distance is 3 or more 
                if (distance >= 3)
                {   // Break loop 
                    break;
                }
            }

            // Close all opened windows 
            SplashKit.CloseAllWindows();
        } 
    }
}