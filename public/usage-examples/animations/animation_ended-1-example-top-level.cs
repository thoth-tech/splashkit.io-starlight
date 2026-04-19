using static SplashKitSDK.SplashKit;

AnimationScript script = LoadAnimationScript("ExplosionScript", "explosion.txt");
Animation anim = CreateAnimation(script, "explosion");

WriteLine("Has animation ended?");
WriteLine(AnimationEnded(anim).ToString());

for (int i = 0; i < 10; i++)
{
    UpdateAnimation(anim);
    Delay(100);

    WriteLine("Current cell: " + AnimationCurrentCell(anim).ToString());

    if (AnimationEnded(anim))
    {
        WriteLine("Animation ended!");
        break;
    }
}

FreeAnimation(anim);
FreeAnimationScript(script);
