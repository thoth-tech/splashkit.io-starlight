using SplashKitSDK;


namespace PointToString
{
    public class Program
    {
        public static void Main()
        {
            // Variable Declaration
            string click = "Mouse clicked at ";
            string mouse_pos = "";

            // Open Window
            SplashKit.OpenWindow("point to string", 600, 600);
            SplashKit.ClearScreen(SplashKit.ColorGhostWhite());

            while(!SplashKit.QuitRequested())
            {
                // check for mouse click
                if(SplashKit.MouseClicked(MouseButton.LeftButton))
                { 
                    mouse_pos = SplashKit.PointToString(SplashKit.MousePosition());
                    SplashKit.ClearScreen(SplashKit.ColorGhostWhite());
                }

                // Print mouse position to screen
                SplashKit.DrawText(click + mouse_pos,SplashKit.ColorBlack(),100,300);
                SplashKit.ProcessEvents();
                SplashKit.RefreshScreen();
            }
        }
    }
}