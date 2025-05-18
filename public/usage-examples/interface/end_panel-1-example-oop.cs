using SplashKitSDK;

namespace EndPanelExample
{
    class Program
    {
        public static void Main()
        {
            // Open a window
            SplashKit.OpenWindow("Panel Example", 600, 400);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen(Color.White);

                // Define the panel
                var panelArea = SplashKit.RectangleFrom(50, 50, 500, 300);

                // Start the panel
                SplashKit.StartPanel("MainPanel", panelArea);

                // Add Labels to the panel
                SplashKit.LabelElement("Hello, welcome to the panel example!");
                SplashKit.LabelElement("This panel is now finalized with end_panel()");

                // Finalize the panel - no more elements can be added after this point
                SplashKit.EndPanel("MainPanel");

                // Draw the interface elements (all panels and labels)
                SplashKit.DrawInterface();

                SplashKit.RefreshScreen(60);
            }
        }
    }

}