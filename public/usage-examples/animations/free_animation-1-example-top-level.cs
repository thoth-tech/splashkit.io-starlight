using static SplashKitSDK.SplashKit;

AnimationScript script = LoadAnimationScript("WalkingScript", "kermit.txt");
Animation anim = CreateAnimation(script, "WalkFront");

WriteLine("Freeing animation: " + AnimationName(anim));
FreeAnimation(anim);

FreeAnimationScript(script);
