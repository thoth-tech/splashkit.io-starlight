using SplashKitSDK;

namespace FadeMusicOutExample
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


            // Wait 1 second before fadeout
            SplashKit.Delay(1000);

            // Fade music out over 3 seconds
            SplashKit.FadeMusicOut(3000);

            // Hold program for 4 seconds
            SplashKit.Delay(4000);

            // Free resources
            SplashKit.FreeAllMusic();
        }    
    }
}
