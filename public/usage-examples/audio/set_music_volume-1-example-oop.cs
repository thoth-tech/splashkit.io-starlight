using SplashKitSDK;

namespace SetMusicVolumeExample
{
    public class Program
    {
        public static void Main()
        {
            // Declare Variables
            double Volume = 1.0;
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
            Window window = SplashKit.OpenWindow("Change Volume", 800, 600);

            // Main Loop
            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // Check for mouse scroll
                MScrollVal += SplashKit.MouseWheelScroll().Y;

                // Check if scroll up & volume not max
                if (ScrollDelta > MScrollVal && Volume > 0)
                {
                    Volume -= 0.01;
                }
                // Check if scroll down & volume not min
                if (ScrollDelta < MScrollVal && Volume < 1)
                {
                    Volume += 0.01;
                }


                // Set volume
                SplashKit.SetMusicVolume(Volume);

                // Stop scroll input from affecting the next iteration
                ScrollDelta = MScrollVal;

                // Draw volume to screen
                window.Clear(Color.White);
                window.DrawText("Scroll to change the volume", Color.Black, 100, 100);
                window.DrawText($"Volume: %{(int)(SplashKit.MusicVolume() * 100)}", Color.Black, 100, 300);
                window.Refresh();

                // Loop Music
                if (!SplashKit.MusicPlaying())
                {
                    music.Play();
                }
            }

            // Cleanup
            SplashKit.CloseAllWindows();
            SplashKit.FreeAllMusic();
        }
    }
}