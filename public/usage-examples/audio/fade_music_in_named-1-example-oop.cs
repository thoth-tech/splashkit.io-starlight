using SplashKitSDK;

namespace FadeMusicInNamedExample
{
    public class Program
    {
        public static void Main()
        {
            // Check if audio is ready to use
            if(! SplashKit.AudioReady())
                SplashKit.OpenAudio();

            // Load music file
            SplashKit.LoadMusic("adventure", "time_for_adventure.mp3");

            // Fade music in over 2 seconds
            SplashKit.FadeMusicIn("adventure", 2000);

            // Hold program for 10 seconds
            SplashKit.Delay(10000);

            // Free resources
            SplashKit.FreeAllMusic();
        }    
    }
}
