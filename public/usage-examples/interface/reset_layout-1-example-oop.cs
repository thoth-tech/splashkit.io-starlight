using SplashKitSDK;

namespace ResetLayoutExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Resetting Interface Layout", 800, 600);

            SplashKit.SetInterfaceStyle(InterfaceStyle.ShadedLightStyle);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                SplashKit.ClearScreen(Color.White);

                if (SplashKit.StartPanel("Layout Reset Demo", SplashKit.RectangleFrom(40, 40, 500, 400)))
                {
                    SplashKit.StartCustomLayout();

                    SplashKit.LabelElement("Before reset");

                    SplashKit.SplitIntoColumns(3);
                    SplashKit.SetLayoutHeight(64);

                    SplashKit.Button("One");
                    SplashKit.Button("Two");
                    SplashKit.Button("Three");

                    // Resetting returns the interface to the default single-column layout.
                    SplashKit.ResetLayout();

                    SplashKit.LabelElement("Default Layout After Reset");

                    SplashKit.Button("Default Layout 1");
                    SplashKit.Button("Default Layout 2");
                    SplashKit.Button("Default Layout 3");

                    SplashKit.EndPanel("Layout Reset Demo");
                }

                SplashKit.DrawInterface();

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}