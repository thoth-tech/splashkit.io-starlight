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

            // Open Window
            Window wind = SplashKit.OpenWindow("Music File", 600, 600);

            Rectangle rect = SplashKit.RectangleFrom(235, 275, 125, 100);

            // Main Loop
            while (!SplashKit.QuitRequested())
            {
                // Create next track button
                wind.Clear(Color.White);
                wind.FillTriangle(Color.Black, 250, 275, 325, 325, 250, 375);
                wind.FillRectangle(Color.Black, 235, 275, 10, 100);
                wind.DrawRectangle(Color.White, rect);

                // Draw name of music track to screen
                wind.DrawText("Current Music: " + SplashKit.MusicName(currentTrack), Color.Black, 100, 150);
                wind.Refresh();

                SplashKit.ProcessEvents();

                // Check for button click
                if (SplashKit.MouseClicked(MouseButton.LeftButton) & SplashKit.PointInRectangle(SplashKit.MousePosition(), rect))
                {
                    if (currentTrack == music1)
                    {
                        currentTrack = music2;
                        currentTrack.Play();
                    }
                    else
                    {
                        currentTrack = music1;
                        currentTrack.Play();
                    }
                }
            }
            SplashKit.CloseAllWindows();
            SplashKit.FreeAllMusic();
        }
    }
}