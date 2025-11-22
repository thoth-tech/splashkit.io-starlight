using SplashKitSDK;

// Top-level C# example for animation_entered_frame
AnimationScript script = LoadAnimationScript("ExplosionScript", "explosion.txt");
Animation anim = CreateAnimation(script, "explosion");
bool entered = AnimationEnteredFrame(anim);
write_line($"Animation entered frame? {entered}");
