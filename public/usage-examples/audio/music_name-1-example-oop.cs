using SplashKitSDK;

namespace MusicNameExample
{
    public class Program
    {
        public static void Main()
        {
            // Check if audio is ready to use
            if (!SplashKit.AudioReady())
            {
                SplashKit.OpenAudio();
            }

            // Load music file and start playback
            Music music1 = SplashKit.LoadMusic("byte blast", "byte-blast.mp3");
            Music music2 = SplashKit.LoadMusic("pixel fight", "pixel-fight.mp3");
            Music currentTrack = music1;
            currentTrack.Play();
            bool musicState = true;
            // Open Window
            SplashKit.OpenWindow("Music File", 600, 600);

            // Create bitmap for pause/play button
            Bitmap playPause = SplashKit.CreateBitmap("playPause", 75, 100);
            SplashKit.FillRectangleOnBitmap(playPause, Color.Black, 0, 0, 25, 100);
            SplashKit.FillRectangleOnBitmap(playPause, Color.Black, 50, 0, 25, 100);

            // Main Loop
            while (!SplashKit.QuitRequested())
            {
                // Create next track button
                SplashKit.ClearScreen();
                SplashKit.FillTriangle(Color.Black, 250, 275, 325, 325, 250, 375);
                SplashKit.FillRectangle(Color.Black, 330, 275, 10, 100);
                SplashKit.DrawBitmap(playPause, 125, 275);

                // Draw name of music track to screen
                SplashKit.DrawText("Current Music: " + SplashKit.MusicName(currentTrack), Color.Black, 100, 150);
                SplashKit.RefreshScreen();

                SplashKit.ProcessEvents();

                // Check for next button click
                if (SplashKit.MouseClicked(MouseButton.LeftButton) & SplashKit.PointInRectangle(SplashKit.MousePosition(), SplashKit.RectangleFrom(250, 275, 125, 100)))
                {
                    if (currentTrack == music1)
                    {
                        currentTrack = music2;
                        currentTrack.Play();
                        musicState = true;
                        SplashKit.ClearBitmap(playPause, Color.White);
                        SplashKit.FillRectangleOnBitmap(playPause, Color.Black, 0, 0, 25, 100);
                        SplashKit.FillRectangleOnBitmap(playPause, Color.Black, 50, 0, 25, 100);

                    }
                    else
                    {
                        currentTrack = music1;
                        currentTrack.Play();
                        musicState = true;
                        SplashKit.ClearBitmap(playPause, Color.White);
                        SplashKit.FillRectangleOnBitmap(playPause, Color.Black, 0, 0, 25, 100);
                        SplashKit.FillRectangleOnBitmap(playPause, Color.Black, 50, 0, 25, 100);
                    }
                }
                // Check for play/pause
                if (SplashKit.MouseClicked(MouseButton.LeftButton) && SplashKit.PointInRectangle(SplashKit.MousePosition(), SplashKit.RectangleFrom(125, 275, 75, 100)))
                {
                    // Check if music is paused or not
                    if (musicState) // Pause if playing
                    {
                        SplashKit.PauseMusic();
                        musicState = false;
                        SplashKit.ClearBitmap(playPause, Color.White);
                        SplashKit.FillTriangleOnBitmap(playPause, Color.Black, 0, 0, 75, 50, 0, 100);
                    }
                    else // Play if paused
                    {
                        SplashKit.ResumeMusic();
                        musicState = true;
                        SplashKit.ClearBitmap(playPause, Color.White);
                        SplashKit.FillRectangleOnBitmap(playPause, Color.Black, 0, 0, 25, 100);
                        SplashKit.FillRectangleOnBitmap(playPause, Color.Black, 50, 0, 25, 100);

                    }
                }
            }
            SplashKit.CloseAllWindows();
            SplashKit.FreeAllMusic();
        }
    }
}