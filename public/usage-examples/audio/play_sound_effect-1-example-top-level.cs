using System;
using SplashKitSDK;

// Top-level statement example
SplashKit.OpenAudio();

SplashKit.LoadSoundEffect("beep", "beep.ogg");
SoundEffect s = SplashKit.SoundEffectNamed("beep");
SplashKit.PlaySoundEffect(s);

// Wait so sound plays before program exits
System.Threading.Thread.Sleep(1200);
SplashKit.CloseAudio();
