using static SplashKitSDK.SplashKit;

AnimationScript script = LoadAnimationScript("WalkingScript", "kermit.txt");
Animation anim = CreateAnimation(script, "WalkFront");

WriteLine("Updating animation and checking frame entry...");

for (int i = 0; i < 10; i++)
{
    UpdateAnimation(anim);
    Delay(100);

    if (AnimationEnteredFrame(anim))
    {
        WriteLine("Entered a new frame!");
        WriteLine("Current cell: " + AnimationCurrentCell(anim).ToString());
    }
}

FreeAnimation(anim);
FreeAnimationScript(script);
