using SplashKitSDK;
using static SplashKitSDK.SplashKit;


// Check if audio is ready to use
if(! AudioReady())
    OpenAudio();

// Load music file
LoadMusic("adventure", "time_for_adventure.mp3");

// Fade music in over 2 seconds
FadeMusicIn("adventure", 2000);

// Hold program for 10 seconds
Delay(10000);

// Free resources
FreeAllMusic();

