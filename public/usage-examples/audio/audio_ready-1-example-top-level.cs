using static SplashKitSDK.SplashKit;

// Check the audio system status
if (AudioReady())
    WriteLine("Audio ready before open_audio: True");
else
    WriteLine("Audio ready before open_audio: False");

OpenAudio();

// Confirm that the audio system is ready
if (AudioReady())
    WriteLine("Audio ready after open_audio: True");
else
    WriteLine("Audio ready after open_audio: False");

CloseAudio();