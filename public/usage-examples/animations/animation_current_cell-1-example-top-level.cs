using SplashKitSDK;

// Top-level C# example showing how to get the current animation cell
AnimationScript script = LoadAnimationScript("WalkingScript", "kermit.txt");
Animation anim = CreateAnimation(script, "WalkFront");
int cell = AnimationCurrentCell(anim);
write_line($"Current cell index: {cell}");
