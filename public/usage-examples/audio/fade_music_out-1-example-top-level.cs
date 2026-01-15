using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Check if audio is ready to use
if (!AudioReady())
{
    OpenAudio();
}

// Load music file and start playback
LoadMusic("adventure", "time_for_adventure.mp3");
PlayMusic("adventure");

// Wait 5 second before fadeout
Delay(5000);

// Fade music out over 5 seconds
FadeMusicOut(5000);

// Hold program for 10 seconds
Delay(10000);

// Free resources
FreeAllMusic();
