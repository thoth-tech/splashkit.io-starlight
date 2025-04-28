using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Check if audio is ready to use
if(! AudioReady())
    OpenAudio();

// Load music file and start playback
Music music = LoadMusic("adventure", "time_for_adventure.mp3");
PlayMusic(music);

// Open Window
Window window = OpenWindow("Music File", 600, 600);

// Main Loop
while (! QuitRequested())
{
    ProcessEvents();

    window.Clear(Color.White);
    // Draw name of music track to screen
    window.DrawText("Current Music: " + MusicName(music), Color.Black, 100, 300);
    window.Refresh();
}
CloseAllWindows();
FreeMusic(music);
