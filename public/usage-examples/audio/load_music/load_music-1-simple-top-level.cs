using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Check if audio is ready to use
if (!AudioReady())
    OpenAudio();

// Load music file
LoadMusic("adventure", "time_for_adventure.mp3");

// Check for successful load
if (HasMusic("adventure"))
    WriteLine("Music successfully loaded. Ready for playback.");
else
    WriteLine("Loading music failed.");

// Cleanup
FreeAllMusic();

