using SplashKitSDK;

// Top-level C# example for AnimationCurrentVector
AnimationScript script = LoadAnimationScript("ExplosionScript", "explosion.txt");
Animation anim = CreateAnimation(script, "Explode");
Vector2D vec = AnimationCurrentVector(anim);
write_line($"Current vector: x={vec.x} y={vec.y}");
