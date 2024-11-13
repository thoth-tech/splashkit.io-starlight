using SplashKitSDK;

namespace ClearScreen 
{
    public class Program 
    {
        public static void Main()
        {
            //Open new window with title and dimensions
            SplashKit.OpenWindow("Blue Background", 800, 600);

            //Use Clear Screen to change the background color to blue 
            SplashKit.ClearScreen(Color.Blue);
            SplashKit.RefreshScreen(60);
            SplashKit.Delay(4000);
            
            //Close loaded windows 
            SplashKit.CloseAllWindows();
        }
    }

}