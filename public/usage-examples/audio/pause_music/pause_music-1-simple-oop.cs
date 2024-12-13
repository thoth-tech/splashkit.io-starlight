using SplashKitSDK;

namespace PauseMusicExample
{
    public static class Program
    {
        public static void Main()
        {
            int MusicState = 1;
            // Check if audio is ready to use
            if (!SplashKit.AudioReady())
                SplashKit.OpenAudio();

            // Load music file
            Music music = SplashKit.LoadMusic("Adventure", "time_for_adventure.mp3");
            music.Play();

            Window window = SplashKit.OpenWindow("Pause/Resume", 300, 200);
            window.DrawText("Playing", Color.Black, 100, 100);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();
                
                // Check for pause/play request
                if (SplashKit.KeyDown(KeyCode.SpaceKey))
                {
                    window.Clear(Color.White);
                    
                    // Check if music is paused or not
                    if (MusicState == 1) // Pause if playing
                    {
                        SplashKit.PauseMusic();
                        MusicState = 0;
                        window.DrawText("Paused...", Color.Black, 100, 100);
                    }
                    else // Play if paused
                    {
                        SplashKit.ResumeMusic();
                        MusicState = 1;
                        window.DrawText("Playing", Color.Black, 100, 100);
                    }
                }
                
                window.Refresh();
                SplashKit.Delay(200);
            }

            // Cleanup
            SplashKit.FreeAllMusic();    
            SplashKit.CloseAllWindows();
        }
    }
}