using SplashKitSDK;

namespace PointOnLine
{
    public class Program
    {
        public static void Main()
        {
            //Variable Declartions
            double bar_x = 100;
            Line slider = SplashKit.LineFrom(100,300,500,300);
            Line bar = SplashKit.LineFrom(bar_x,310,bar_x,290);
            double percent = 0;
            string volume = "Volume: ";


            // Create window and draw initial Lines
            SplashKit.OpenWindow("point on Line",600,600);
            SplashKit.ClearScreen(SplashKit.ColorWhite());

            SplashKit.DrawLine(SplashKit.ColorBlack(),slider);
            SplashKit.DrawLine(SplashKit.ColorBlack(),bar);
            SplashKit.DrawText(volume + percent.ToString(),SplashKit.ColorBlack(),200,450);
            SplashKit.RefreshScreen();

            while (! SplashKit.QuitRequested())
            {
                
                SplashKit.ProcessEvents();

                // Check if user is holding click on the bar Line
                while (SplashKit.MouseDown(MouseButton.LeftButton) & SplashKit.PointOnLine(SplashKit.MousePosition(),bar))
                {

                    SplashKit.ClearScreen(SplashKit.ColorWhite());
                    bar_x = SplashKit.MousePosition().X; // sets bar_x value to mouse x value
                    percent = ((bar_x - 100) / (500 - 100)) * 100; // convert bar_x position to percent value
                    bar = SplashKit.LineFrom(bar_x,310,bar_x,290);
                    
                    // redraw Lines and volume text
                    SplashKit.DrawLine(SplashKit.ColorBlack(),bar);
                    SplashKit.DrawLine(SplashKit.ColorBlack(),slider);
                    SplashKit.DrawText(volume + percent.ToString(),SplashKit.ColorBlack(),200,450);
                    SplashKit.RefreshScreen();
                    SplashKit.ProcessEvents();

                }

    
            }   
        }
    }
}