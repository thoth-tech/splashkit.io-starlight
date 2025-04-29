using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Check if audio is ready to use
if (!AudioReady())
{
    OpenAudio();
}

String[] musicNames = { "adventure", "NoAdventure" };

LoadMusic("adventure", "time_for_adventure.mp3");

for (int i = 0; i < musicNames.Length; i++)
{
    // Check for successful load
    if (HasMusic(musicNames[i]))
    {
        WriteLine($"{musicNames[i]} successfully loaded. Ready for playback.");
    }
    else
    {
        WriteLine($"Failed to load {musicNames[i]}, check file location.");
    }
}
// Cleanup
FreeAllMusic();
