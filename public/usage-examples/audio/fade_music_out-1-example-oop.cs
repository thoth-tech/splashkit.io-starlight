using SplashKitSDK;

namespace FadeMusicOutExample
{
    public class Program
    {
        public static void Main()
        {
            // Check if audio is ready to use
            if (!SplashKit.AudioReady())
            {
                SplashKit.OpenAudio();
            }

            // Load music file and start playback
            Music music = SplashKit.LoadMusic("adventure", "time_for_adventure.mp3");
            music.Play();

            // Wait 5 second before fadeout
            SplashKit.Delay(5000);

            // Fade music out over 5 seconds
            SplashKit.FadeMusicOut(5000);

            // Hold program for 10 seconds
            SplashKit.Delay(10000);

            // Free resources
            SplashKit.FreeAllMusic();
        }
    }
}
