using static SplashKitSDK.SplashKit;

AnimationScript script = LoadAnimationScript("WalkingScript", "kermit.txt");

WriteLine("Freeing animation script: " + AnimationScriptName(script));
FreeAnimationScript(script);
