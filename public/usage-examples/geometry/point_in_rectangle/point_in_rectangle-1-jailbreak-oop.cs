using SplashKitSDK;

namespace PointInRectangle
{
    public class Program
    {
        public static void Main()
        {
            //Variable Declerations
            Point2D mouse_point;
            Rectangle boundary = SplashKit.RectangleFrom(150,150,300,100);


            SplashKit.OpenWindow("point in Rectangle", 600, 600);


            while(!SplashKit.QuitRequested())
            {   
                SplashKit.ProcessEvents();
                // get mouse position and draw boundary to screen
                mouse_point = SplashKit.MousePosition();
                SplashKit.ClearScreen(SplashKit.ColorGreen());
                SplashKit.FillRectangle(SplashKit.ColorWhite(), boundary);

                // Check if mouse is in the boundary
                if(!SplashKit.PointInRectangle(mouse_point,boundary))
                {
                    //flash screen red and blue if mouse has escaped boundary
                    SplashKit.ClearScreen(SplashKit.ColorDarkRed());
                    SplashKit.FillRectangle(SplashKit.ColorWhite(), boundary);
                    SplashKit.DrawText("JAILBREAK",SplashKit.ColorBlack(),250.0,400.0);
                    SplashKit.RefreshScreen(2);
                    SplashKit.ClearScreen(SplashKit.ColorRoyalBlue());
                    SplashKit.FillRectangle(SplashKit.ColorWhite(), boundary);
                    SplashKit.RefreshScreen(2);
            
                }
                SplashKit.RefreshScreen();
            }
            SplashKit.CloseAllWindows();
        }
    }

}



