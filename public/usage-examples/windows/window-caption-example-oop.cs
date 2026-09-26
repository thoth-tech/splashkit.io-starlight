using SplashKitSDK;

namespace WindowCaptionExample
{
    public class Program
    {
        public static void Main()
        {
            // Open a new window
            Window myWindow = SplashKit.OpenWindow("My SplashKit Window", 800, 600);

            // Get the window caption
            string caption = SplashKit.WindowCaption(myWindow);

            // Keep the program running until the user closes the window
            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // Draw content on the screen
                myWindow.Clear(SplashKit.ColorWhite());

                myWindow.DrawText("Window caption:", SplashKit.ColorBlack(), 260, 250);
                myWindow.DrawText(caption, SplashKit.ColorBlue(), 260, 290);

                myWindow.Refresh();
            }

            // Close all open windows
            SplashKit.CloseAllWindows();
        }
    }
}