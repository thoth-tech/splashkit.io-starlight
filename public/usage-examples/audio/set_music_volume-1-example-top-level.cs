using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Declare Variables
double Volume = 1.0f;
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
OpenWindow("Change Volume", 800, 600);

// Main Loop
while (!QuitRequested())
{
    ProcessEvents();

    // Check for mouse scroll
    MScrollVal += MouseWheelScroll().Y;

    // Check if scroll up & volume not max
    if (ScrollDelta > MScrollVal && Volume > 0)
    {
        Volume -= 0.01f;
    }
    // Check if scroll down & volume not min
    if (ScrollDelta < MScrollVal && Volume < 1)
    {
        Volume += 0.01f;
    }

    // Set volume
    SetMusicVolume(Volume);

    // Stop scroll input from affecting the next iteration
    ScrollDelta = MScrollVal;

    // Draw volume to screen
    ClearScreen(Color.White);
    DrawText("Scroll to change the volume", Color.Black, 100, 100);
    DrawText($"Volume: %{(int)(MusicVolume() * 100)}", Color.Black, 100, 300);
    RefreshScreen();

    // Loop Music
    if (!MusicPlaying())
    {
        PlayMusic("adventure");
    }
}

// Cleanup
CloseAllWindows();
FreeAllMusic();
