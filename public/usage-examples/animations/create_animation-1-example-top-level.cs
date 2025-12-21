using static SplashKitSDK.SplashKit;

AnimationScript script = LoadAnimationScript("WalkingScript", "kermit.txt");

WriteLine("Creating animation...");
Animation anim = CreateAnimation(script, "WalkFront");

WriteLine("Animation name:");
WriteLine(AnimationName(anim));

FreeAnimation(anim);
FreeAnimationScript(script);
