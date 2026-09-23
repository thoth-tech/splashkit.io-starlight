using SplashKitSDK;

namespace AudioReadyExample
{
    public class Program
    {
        public static void Main()
        {
            // Check the audio system status
            if (SplashKit.AudioReady())
                SplashKit.WriteLine("Audio ready before open_audio: True");
            else
                SplashKit.WriteLine("Audio ready before open_audio: False");

            SplashKit.OpenAudio();

            // Confirm that the audio system is ready
            if (SplashKit.AudioReady())
                SplashKit.WriteLine("Audio ready after open_audio: True");
            else
                SplashKit.WriteLine("Audio ready after open_audio: False");

            SplashKit.CloseAudio();
        }
    }
}