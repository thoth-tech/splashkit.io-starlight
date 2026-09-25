using SplashKitSDK;

namespace SplitIntoColumnsExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Three Column Layout", 800, 600);

            SplashKit.SetInterfaceStyle(InterfaceStyle.ShadedLightStyle);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                SplashKit.ClearScreen(SplashKit.ColorWhite());

                if (SplashKit.StartPanel("Split Into Columns Demo", SplashKit.RectangleFrom(40, 40, 600, 180)))
                {
                    SplashKit.StartCustomLayout();

                    SplashKit.SplitIntoColumns(3);
                    SplashKit.SetLayoutHeight(64);

                    SplashKit.Button("Column 1");
                    SplashKit.Button("Column 2");
                    SplashKit.Button("Column 3");

                    SplashKit.EndPanel("Split Into Columns Demo");
                }

                SplashKit.DrawInterface();

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}