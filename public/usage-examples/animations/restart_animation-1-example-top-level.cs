using static SplashKitSDK.SplashKit;

AnimationScript script = LoadAnimationScript("WalkingScript", "kermit.txt");
Animation anim = CreateAnimation(script, "WalkFront");

WriteLine("Updating animation a few times...");
for (int i = 0; i < 10; i++)
{
    UpdateAnimation(anim);
}

WriteLine("Restarting animation...");
RestartAnimation(anim);

FreeAnimation(anim);
FreeAnimationScript(script);
