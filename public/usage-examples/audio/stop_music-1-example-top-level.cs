using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Check if audio is ready to use
if (!AudioReady())
{
    OpenAudio();
}


// Load music file
Music music = LoadMusic("adventure", "time_for_adventure.mp3");
PlayMusic(music);
bool musicPlaying = true;

OpenWindow("Stop/Start", 300, 200);

while (!QuitRequested())
{
    ProcessEvents();

    // Check for stop/play request
    if (MouseClicked(MouseButton.LeftButton))
    {
        if (musicPlaying)
        {
            // Stop if playing
            StopMusic();
            musicPlaying = false;
        }
        else
        {
            // Play if stopped
            PlayMusic(music);
            musicPlaying = true;
        }
    }

    // Display text showing if music is playing or not
    ClearScreen(ColorWhite());
    if (musicPlaying)
    {
        DrawText("Music Playing", ColorBlack(), 100, 100);
    }
    else
    {
        DrawText("Music Stopped", ColorBlack(), 100, 100);
    }
    RefreshScreen();
}

// Cleanup
FreeAllMusic();
