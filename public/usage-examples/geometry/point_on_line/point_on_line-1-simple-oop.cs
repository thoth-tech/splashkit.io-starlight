using SplashKitSDK;

namespace PointOnLine
{
    public class Program
    {
        public static void Main()
        {
            //Variable Declartions
            
            Line ln = SplashKit.LineFrom(100,300,500,300);


            // Create window
            SplashKit.OpenWindow("point on line",600,600);

            while (! SplashKit.QuitRequested())
            {
                //Display line
                SplashKit.ClearScreen(SplashKit.ColorWhite());
                SplashKit.DrawLine(SplashKit.ColorBlack(),ln);
                
                //Draw text if curser is on line
                if(SplashKit.PointOnLine(SplashKit.MousePosition(),ln))
                {
                    SplashKit.DrawText("Point on line" + SplashKit.PointToString(SplashKit.MousePosition()),SplashKit.ColorBlack(),200,450);
                }
                
                
                SplashKit.RefreshScreen();
                SplashKit.ProcessEvents();

               
            
    
            }   
        }
    }
}