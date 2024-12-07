using SplashKitSDK;

namespace PointToString
{
    public class Program
    {
        public static void Main()
        {
            // Variable Declaration
            string ClickMessage = "Mouse clicked at ";
            string MousePositionText = "";

            // Open Window
            Window WindowInstance = new Window("Mouse Clicked Location", 600, 600);
            WindowInstance.Clear(Color.GhostWhite);

            while (!SplashKit.QuitRequested())
            {
                // Check for mouse click
                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                { 
                    MousePositionText = SplashKit.PointToString(SplashKit.MousePosition());
                    WindowInstance.Clear(Color.GhostWhite);
                }

                // Print mouse position to screen
                WindowInstance.DrawText(ClickMessage + MousePositionText, Color.Black, 100, 300);
                SplashKit.ProcessEvents();
                WindowInstance.Refresh();
            }

            WindowInstance.Close();
        }
    }
}