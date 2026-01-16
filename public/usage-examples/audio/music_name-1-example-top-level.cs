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
bool musicState = true;

// Open Window
OpenWindow("Music File", 600, 600);

// Create bitmap for pause/play button
Bitmap playPause = CreateBitmap("playPause", 75, 100);
FillRectangleOnBitmap(playPause, ColorBlack(), 0, 0, 25, 100);
FillRectangleOnBitmap(playPause, ColorBlack(), 50, 0, 25, 100);

// Main Loop
while (!QuitRequested())
{
    // Create next track button
    ClearScreen(ColorWhite());
    FillTriangle(ColorBlack(), 250, 275, 325, 325, 250, 375);
    FillRectangle(ColorBlack(), 330, 275, 10, 100);
    DrawBitmap(playPause, 125, 275);

    // Draw name of music track to screen
    DrawText("Current Music: " + MusicName(currentTrack), ColorBlack(), 100, 150);
    RefreshScreen();

    ProcessEvents();

    // Check for button click
    if (MouseClicked(MouseButton.LeftButton) && PointInRectangle(MousePosition(), RectangleFrom(250, 275, 125, 100)))
    {
        if (currentTrack == music1)
        {
            currentTrack = music2;
            currentTrack.Play();
            musicState = true;
            ClearBitmap(playPause, ColorWhite());
            FillRectangleOnBitmap(playPause, ColorBlack(), 0, 0, 25, 100);
            FillRectangleOnBitmap(playPause, ColorBlack(), 50, 0, 25, 100);

        }
        else
        {
            currentTrack = music1;
            currentTrack.Play();
            musicState = true;
            ClearBitmap(playPause, ColorWhite());
            FillRectangleOnBitmap(playPause, ColorBlack(), 0, 0, 25, 100);
            FillRectangleOnBitmap(playPause, ColorBlack(), 50, 0, 25, 100);
        }
    }
    // Check for play/pause
    if (MouseClicked(MouseButton.LeftButton) && PointInRectangle(MousePosition(), RectangleFrom(125, 275, 75, 100)))
    {
        // Check if music is paused or not
        if (musicState) // Pause if playing
        {
            PauseMusic();
            musicState = false;
            ClearBitmap(playPause, ColorWhite());
            FillTriangleOnBitmap(playPause, ColorBlack(), 0, 0, 75, 50, 0, 100);
        }
        else // Play if paused
        {
            ResumeMusic();
            musicState = true;
            ClearBitmap(playPause, ColorWhite());
            FillRectangleOnBitmap(playPause, ColorBlack(), 0, 0, 25, 100);
            FillRectangleOnBitmap(playPause, ColorBlack(), 50, 0, 25, 100);

        }
    }
}
CloseAllWindows();
FreeAllMusic();