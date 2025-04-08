using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Declare Variables
float Volume = 1.0f;
double MScrollVal = 1.0;
double ScrollDelta = MScrollVal;

// Check if audio is ready to use
if (!AudioReady())
{
    OpenAudio();
}

// Load music file and start playback
LoadMusic("adventure", "time_for_adventure.mp3");
PlayMusic("adventure");

// Open Window
OpenWindow("Change Volume", 600, 600);

// Main Loop
while (!QuitRequested())
{
    ProcessEvents();

    // Check for mouse scroll
    MScrollVal += MouseWheelScroll().Y;

    // Check if scroll up & volume not max
    if (ScrollDelta > MScrollVal && Volume > 0)
    {
        Volume -= 0.05f;
    }
    // Check if scroll down & volume not min
    if (ScrollDelta < MScrollVal && Volume < 1)
    {
        Volume += 0.05f;
    }

    // Set volume
    SetMusicVolume(Volume);

    // Reset scroll delta
    ScrollDelta = MScrollVal;

    // Draw volume to screen
    ClearScreen(Color.White);
    DrawText($"Volume: {MusicVolume()}", Color.Black, 100, 300);
    RefreshScreen();
}

// Cleanup
CloseAllWindows();
FreeAllMusic();
