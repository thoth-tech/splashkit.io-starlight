using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Check if audio is ready to use
if (!AudioReady())
    OpenAudio();

// Load music file
Music music = LoadMusic("adventure", "time_for_adventure.mp3");
PlayMusic(music);

OpenWindow("Stop Music", 300, 200);
DrawText("Click to stop the music", Color.Black, 25, 100);
RefreshScreen();

while (!QuitRequested())
{
    ProcessEvents();
    
    // Check for pause/play request
    if (MouseClicked(MouseButton.LeftButton))
    {
        ClearScreen(Color.White);
        StopMusic();
        DrawText("Music Stopped. Exiting...", Color.Black, 25, 100);
        RefreshScreen();
        Delay(1300);
        CloseAllWindows();
    }
}

// Cleanup
FreeAllMusic();
