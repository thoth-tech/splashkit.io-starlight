using SplashKitSDK;

namespace LoadMusicExample
{
    public class Program

    {
        public static void Main()
        {
            // Check if audio is ready to use
            if (!SplashKit.AudioReady())
                SplashKit.OpenAudio();

            // Load music file
            SplashKit.LoadMusic("adventure", "time_for_adventure.mp3");

            // Check for successful load
            if (SplashKit.HasMusic("adventure"))
                SplashKit.WriteLine("Music successfully loaded. Ready for playback.");
            else
                SplashKit.WriteLine("Loading music failed.");

            // Cleanup
            SplashKit.FreeAllMusic();
        }
        
    }
}
