using SplashKitSDK;

namespace CloseAudioExample
{
    public class Program
    {
        public static void Main()
        {
            bool audioClosed = false;

            SplashKit.OpenWindow("Audio Control Demonstration", 700, 420);
            SplashKit.OpenAudio();

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // Close the audio system once when the user requests it.
                if (SplashKit.KeyTyped(KeyCode.SpaceKey) && !audioClosed)
                {
                    SplashKit.CloseAudio();
                    audioClosed = true;
                }

                SplashKit.ClearScreen(Color.RGBColor(242, 246, 252));
                SplashKit.FillRectangle(Color.RGBColor(31, 45, 72), 0, 0, 700, 90);
                SplashKit.DrawText("Close Audio Demonstration", Color.White, 215, 35);

                SplashKit.DrawText("Press SPACE to close the SplashKit audio system.", Color.Black, 180, 135);
                SplashKit.FillRectangle(Color.White, 170, 190, 360, 110);

                if (audioClosed)
                {
                    SplashKit.FillCircle(Color.RGBColor(211, 47, 47), 225, 245, 18);
                    SplashKit.DrawText("Audio status: CLOSED", Color.RGBColor(211, 47, 47), 265, 238);
                    SplashKit.DrawText("All audio has been stopped.", Color.Black, 250, 270);
                }
                else
                {
                    SplashKit.FillCircle(Color.RGBColor(46, 125, 50), 225, 245, 18);
                    SplashKit.DrawText("Audio status: READY", Color.RGBColor(46, 125, 50), 265, 238);
                    SplashKit.DrawText("The audio system is available.", Color.Black, 245, 270);
                }

                SplashKit.DrawText("Close the window to finish.", Color.RGBColor(80, 90, 105), 260, 350);
                SplashKit.RefreshScreen(60);
            }

            // Release the audio system if the window was closed before Space was pressed.
            if (!audioClosed)
            {
                SplashKit.CloseAudio();
            }
        }
    }
}
