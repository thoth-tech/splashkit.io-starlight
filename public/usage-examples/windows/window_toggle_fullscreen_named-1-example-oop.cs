using SplashKitSDK;

namespace WindowToggleFullscreenNamedExample
{
    public class Program
    {
        public static void Main()
        {
            // The remote only needs the player's caption, so it never has to hold the player's window handle
            string playerCaption = "Video Player";

            Window remoteWindow = SplashKit.OpenWindow("Remote Control", 480, 280);
            Window playerWindow = SplashKit.OpenWindow(playerCaption, 480, 280);

            // Place the windows side by side so both stay visible
            remoteWindow.MoveTo(60, 100);
            playerWindow.MoveTo(580, 100);

            int commandCount = 0;

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // Pressing F is the remote's fullscreen button, and pressing it again undoes it
                if (SplashKit.KeyTyped(KeyCode.FKey))
                {
                    SplashKit.WindowToggleFullscreen(playerCaption);
                    commandCount++;
                }

                remoteWindow.Clear(Color.White);
                remoteWindow.DrawText("Remote Control", Color.Black, "arial", 40, 20, 40);
                remoteWindow.DrawText("Press F to toggle the player", Color.DarkGray, "arial", 20, 20, 130);
                remoteWindow.Refresh();

                // Count the commands on the player itself, because the remote is hidden while the player fills the screen
                playerWindow.Clear(Color.Black);
                playerWindow.DrawText("Now Playing", Color.White, "arial", 40, 20, 40);
                playerWindow.DrawText($"Commands received: {commandCount}", Color.LightGray, "arial", 30, 20, 120);
                playerWindow.DrawText("Press F to toggle", Color.LightGray, "arial", 20, 20, 190);
                playerWindow.Refresh();
            }

            SplashKit.CloseAllWindows();
        }
    }
}
