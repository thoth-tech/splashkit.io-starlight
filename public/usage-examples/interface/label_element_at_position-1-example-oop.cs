using SplashKitSDK;

namespace LabelElementExample
{
    public class Program
    {
        public static void Main()
        {
            string headingText = "Interface Labels";
            string firstLabel = "Welcome to SplashKit";
            string secondLabel = "This is a label element";

            SplashKit.OpenWindow("Simple Interface Layout", 800, 600);

            SplashKit.SetInterfaceStyle(InterfaceStyle.ShadedLightStyle);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                SplashKit.ClearScreen(Color.White);

                // Labels are grouped together to form a simple interface section.
                SplashKit.LabelElement(headingText, SplashKit.RectangleFrom(320, 300, 400, 40));
                SplashKit.LabelElement(firstLabel, SplashKit.RectangleFrom(300, 250, 400, 40));
                SplashKit.LabelElement(secondLabel, SplashKit.RectangleFrom(300, 200, 400, 40));

                SplashKit.DrawInterface();

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}