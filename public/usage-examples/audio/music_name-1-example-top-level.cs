using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Check if audio is ready to use
if (!AudioReady())
{
    OpenAudio();
}

// Load music file and start playback
Music music1 = LoadMusic("byte blast", "byte-blast.mp3");
Music music2 = LoadMusic("pixel fight", "pixel-fight.mp3");
Music currentTrack = music1;
PlayMusic(currentTrack);

// Open Window
OpenWindow("Music File", 600, 600);

Rectangle rect = RectangleFrom(235, 275, 125, 100);

// Main Loop
while (!QuitRequested())
{
    // Create next track button
    ClearScreen(ColorWhite());
    FillTriangle(ColorBlack(), 250, 275, 325, 325, 250, 375);
    FillRectangle(ColorBlack(), 235, 275, 10, 100);
    DrawRectangle(ColorWhite(), rect);

    // Draw name of music track to screen
    DrawText("Current Music: " + MusicName(currentTrack), ColorBlack(), 100, 150);
    RefreshScreen();

    ProcessEvents();

    // Check for button click
    if (MouseClicked(MouseButton.LeftButton) & PointInRectangle(MousePosition(), rect))
    {
        if (currentTrack == music1)
        {
            currentTrack = music2;
            PlayMusic(currentTrack);
        }
        else
        {
            currentTrack = music1;
            PlayMusic(currentTrack);
        }
    }
}
CloseAllWindows();
FreeAllMusic();