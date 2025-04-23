using SplashKitSDK;

namespace CreatingUserInterfaces
{
    public class Program
    {
        public static void Main()
        {
            // open a window and clear it to white
            Window window = new Window("Button Toggle", 600, 400);
            Color backgroundColor = Color.White;

            Rectangle buttonRect = SplashKit.RectangleFrom(200, 180, 200, 40);

            while (!window.CloseRequested)
            {
                SplashKit.ProcessEvents();

                // toggle color if the button is clicked
                if (SplashKit.Button("Click Me!", buttonRect))
                {
                    backgroundColor =
                        backgroundColor == Color.White ? Color.LightBlue : Color.White;
                }

                // clear screen, draw button, draw interface
                window.Clear(backgroundColor);
                SplashKit.Button("Click Me!", buttonRect);
                SplashKit.DrawInterface();
                window.Refresh(60);
            }

            // close all open windows
            SplashKit.CloseAllWindows();
        }
    }
}
