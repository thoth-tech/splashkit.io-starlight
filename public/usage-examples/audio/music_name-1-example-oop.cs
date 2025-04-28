using SplashKitSDK;

namespace MusicNameExample
{
    public class Program
    {
        public static void Main()
        {
            // Check if audio is ready to use
            if(! SplashKit.AudioReady())
                SplashKit.OpenAudio();

            // Load music file and start playback
            Music music = SplashKit.LoadMusic("adventure", "time_for_adventure.mp3");
            music.Play();

            // Open Window
            Window window = SplashKit.OpenWindow("Music File", 600, 600);

            // Main Loop
            while (! SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();
                
                window.Clear(Color.White);
                // Draw name of music track to screen
                window.DrawText("Current Music: " + SplashKit.MusicName(music), Color.Black, 100, 300);
                window.Refresh();
            }
            SplashKit.CloseAllWindows();
            SplashKit.FreeMusic(music);
        }
    }
}