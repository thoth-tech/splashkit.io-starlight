using SplashKitSDK;

// Top-level C# example
AnimationScript script = LoadAnimationScript("WalkingScript", "kermit.txt");
int count = AnimationCount(script);
write_line($"This script contains {count} animations.");
