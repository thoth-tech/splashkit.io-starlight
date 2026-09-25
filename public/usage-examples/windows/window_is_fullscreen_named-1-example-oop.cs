using SplashKitSDK;

namespace WindowIsFullscreenNamedExample
{
    public class Program
    {
        public static void Main()
        {
            // Keep the caption in one variable so the window and the lookups can never disagree
            string previewCaption = "Preview";

            Window dashboardWindow = SplashKit.OpenWindow("Dashboard", 480, 280);
            Window previewWindow = SplashKit.OpenWindow(previewCaption, 480, 280);

            // Place the windows side by side so both stay visible
            dashboardWindow.MoveTo(60, 100);
            previewWindow.MoveTo(580, 100);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // The F key sends the preview window in and out of fullscreen
                if (SplashKit.KeyTyped(KeyCode.FKey))
                {
                    SplashKit.WindowToggleFullscreen(previewCaption);
                }

                // Look the window up by its caption, so no window handle is needed here
                bool previewIsFullscreen = SplashKit.WindowIsFullscreen(previewCaption);

                // The whole dashboard acts as a status light
                if (previewIsFullscreen)
                {
                    dashboardWindow.Clear(Color.LightGreen);
                    dashboardWindow.DrawText("Preview is fullscreen", Color.Black, "arial", 30, 20, 60);
                }
                else
                {
                    dashboardWindow.Clear(Color.LightGray);
                    dashboardWindow.DrawText("Preview is windowed", Color.Black, "arial", 30, 20, 60);
                }

                dashboardWindow.DrawText("Press F to toggle the preview", Color.DarkGray, "arial", 20, 20, 140);
                dashboardWindow.Refresh();

                previewWindow.Clear(Color.LightBlue);
                previewWindow.DrawText("Preview", Color.Black, "arial", 40, 20, 40);

                // The preview shows the same answer, because the dashboard is hidden while it fills the screen
                if (previewIsFullscreen)
                {
                    previewWindow.DrawText("Fullscreen: true", Color.Black, "arial", 30, 20, 120);
                }
                else
                {
                    previewWindow.DrawText("Fullscreen: false", Color.Black, "arial", 30, 20, 120);
                }

                previewWindow.DrawText("Press F to toggle", Color.DarkGray, "arial", 20, 20, 190);
                previewWindow.Refresh();
            }

            SplashKit.CloseAllWindows();
        }
    }
}
