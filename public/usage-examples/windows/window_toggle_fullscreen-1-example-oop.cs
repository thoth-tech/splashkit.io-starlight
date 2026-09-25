using SplashKitSDK;

namespace WindowToggleFullscreenExample
{
    public class Program
    {
        public static void Main()
        {
            Window notesWindow = SplashKit.OpenWindow("Presenter Notes", 480, 280);
            Window projectorWindow = SplashKit.OpenWindow("Projector", 480, 280);

            // Place the windows side by side so both stay visible
            notesWindow.MoveTo(60, 100);
            projectorWindow.MoveTo(580, 100);

            int toggleCount = 0;

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // Only the projector goes fullscreen, so the notes stay on the presenter's own screen
                if (SplashKit.KeyTyped(KeyCode.FKey))
                {
                    SplashKit.WindowToggleFullscreen(projectorWindow);
                    toggleCount++;
                }

                notesWindow.Clear(Color.White);
                notesWindow.DrawText("Presenter Notes", Color.Black, "arial", 40, 20, 40);
                notesWindow.DrawText("Press F to toggle the projector", Color.DarkGray, "arial", 20, 20, 130);
                notesWindow.Refresh();

                // Show the count on the projector itself, because the notes are hidden while it fills the screen
                if (projectorWindow.IsFullscreen)
                {
                    projectorWindow.Clear(Color.Black);
                    projectorWindow.DrawText("Big Slide", Color.White, "arial", 40, 20, 40);
                    projectorWindow.DrawText($"Toggles so far: {toggleCount}", Color.LightGray, "arial", 30, 20, 120);
                }
                else
                {
                    projectorWindow.Clear(Color.White);
                    projectorWindow.DrawText("Big Slide", Color.Black, "arial", 40, 20, 40);
                    projectorWindow.DrawText($"Toggles so far: {toggleCount}", Color.DarkGray, "arial", 30, 20, 120);
                }

                projectorWindow.Refresh();
            }

            SplashKit.CloseAllWindows();
        }
    }
}
