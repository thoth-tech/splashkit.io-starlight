using SplashKitSDK;

namespace SetMusicVolumeExample
{
    public class Program
    {
        public static void Main()
        {
            // Declare Variables
            float Volume = 1.0f;
            double MScrollVal = 1.0;
            double ScrollDelta = MScrollVal;

            // Check if audio is ready to use
            if (!SplashKit.AudioReady())
            {
                SplashKit.OpenAudio();
            }

            // Load music file and start playback
            Music music = SplashKit.LoadMusic("adventure", "time_for_adventure.mp3");
            music.Play();

            // Open Window
            Window window = SplashKit.OpenWindow("Change Volume", 600, 600);

            // Main Loop
            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // Check for mouse scroll
                MScrollVal += SplashKit.MouseWheelScroll().Y;

                // Check if scroll up & volume not max
                if (ScrollDelta > MScrollVal && Volume > 0)
                {
                    Volume -= 0.05f;
                }
                // Check if scroll down & volume not min
                if (ScrollDelta < MScrollVal && Volume < 1)
                {
                    Volume += 0.05f;
                }

                // Set volume
                SplashKit.SetMusicVolume(Volume);

                // Reset scroll delta
                ScrollDelta = MScrollVal;

                // Draw volume to screen
                window.Clear(Color.White);
                window.DrawText($"Volume: {MusicVolume()}", Color.Black, 100, 300);
                window.Refresh();
            }

            // Cleanup
            SplashKit.CloseAllWindows();
            SplashKit.FreeAllMusic();
        }
    }
}