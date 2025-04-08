using SplashKitSDK;

namespace PauseMusicExample
{
    public static class Program
    {
        public static void Main()
        {
            // Check if audio is ready to use
            if (!SplashKit.AudioReady())
                SplashKit.OpenAudio();

            // Load music file
            Music music = new Music("adventure", "time_for_adventure.mp3");
            music.Play();

            Window window = new Window("Stop Music", 300, 200);
            window.DrawText("Click to stop the music", Color.Black, 25, 100);
            window.Refresh();

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();
                
                // Check for pause/play request
                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    SplashKit.ClearScreen(Color.White);
                    SplashKit.StopMusic();
                    window.DrawText("Music Stopped. Exiting...", Color.Black, 25, 100);
                    window.Refresh();
                    SplashKit.Delay(1300);
                    SplashKit.CloseAllWindows();
                }
            }

            // Cleanup
            SplashKit.FreeAllMusic();
        }
    }
}