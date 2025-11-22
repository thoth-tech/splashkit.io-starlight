using SplashKitSDK;

// Top-level C# example for AnimationEnded
AnimationScript script = LoadAnimationScript("ExplosionScript", "explosion.txt");
Animation anim = CreateAnimation(script, "explosion");
bool ended = AnimationEnded(anim);
write_line($"Animation ended? {ended}");
