using static SplashKitSDK.SplashKit;

AnimationScript script = LoadAnimationScript("WalkingScript", "kermit.txt");
Animation anim = CreateAnimation(script, "WalkFront");

WriteLine("Frame time in current frame:");

for (int i = 0; i < 5; i++)
{
    UpdateAnimation(anim);
    Delay(200);

    WriteLine("Frame time: " + AnimationFrameTime(anim).ToString());
}

FreeAnimation(anim);
FreeAnimationScript(script);
