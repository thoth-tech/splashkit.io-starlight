using SplashKitSDK;

namespace LoadMusicExample
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

            String[] musicNames = { "adventure", "NoAdventure" };

            SplashKit.LoadMusic("adventure", "time_for_adventure.mp3");
            for (int i = 0; i < musicNames.Length; i++)
            {
                // Check for successful load
                if (SplashKit.HasMusic(musicNames[i]))
                {
                    SplashKit.WriteLine($"{musicNames[i]} successfully loaded. Ready for playback.");
                }
                else
                {
                    SplashKit.WriteLine($"Failed to load {musicNames[i]}, check file location.");
                }
                // Cleanup
                SplashKit.FreeAllMusic();
            }
        }
    }
}
