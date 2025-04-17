using SplashKitSDK;
using static SplashKitSDK.SplashKit;

int MusicState = 1;

// Check if audio is ready to use
if (!AudioReady())
    OpenAudio();

// Load music file
Music music = LoadMusic("Adventure", "time_for_adventure.mp3");
PlayMusic(music);

OpenWindow("Pause/Resume", 300, 200);
DrawText("Playing", Color.Black, 100, 100);

while (!QuitRequested())
{
    ProcessEvents();

    // Check for pause/play request
    if (KeyDown(KeyCode.SpaceKey))
    {
        ClearScreen(Color.White);

        // Check if music is paused or not
        if (MusicState == 1) // Pause if playing
        {
            PauseMusic();
            MusicState = 0;
            DrawText("Paused...", Color.Black, 100, 100);
        }
        else // Play if paused
        {
            ResumeMusic();
            MusicState = 1;
            DrawText("Playing", Color.Black, 100, 100);
        }
    }
    RefreshScreen();
    Delay(200);
}
// Cleanup
FreeAllMusic();
CloseAllWindows();