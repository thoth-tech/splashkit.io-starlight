using SplashKitSDK;

// Top-level C# example for Animation.FrameTime
AnimationScript script = LoadAnimationScript("ExplosionScript", "explosion.txt");
Animation anim = CreateAnimation(script, "explosion");
float t = AnimationFrameTime(anim);
write_line($"Time spent in current frame: {t}");
