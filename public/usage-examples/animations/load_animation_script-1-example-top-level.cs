using static SplashKitSDK.SplashKit;

WriteLine("Loading animation script...");

AnimationScript script = LoadAnimationScript("WalkingScript", "kermit.txt");

WriteLine("Script name:");
WriteLine(AnimationScriptName(script));

WriteLine("Animations in script: " + AnimationCount(script).ToString());

FreeAnimationScript(script);
