using SplashKitSDK;

// Top-level C# example for AnimationIndex
AnimationScript script = LoadAnimationScript("WalkingScript", "kermit.txt");
int idx = AnimationIndex(script, "WalkFront");
write_line($"Index of WalkFront: {idx}");
