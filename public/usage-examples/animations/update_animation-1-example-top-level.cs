using static SplashKitSDK.SplashKit;

AnimationScript script = LoadAnimationScript("WalkingScript", "kermit.txt");
Animation anim = CreateAnimation(script, "WalkFront");

WriteLine("Updating animation...");

for (int i = 0; i < 5; i++)
{
    UpdateAnimation(anim);
    Delay(100);

    WriteLine("Current cell: " + AnimationCurrentCell(anim).ToString());
}

FreeAnimation(anim);
FreeAnimationScript(script);
