using static SplashKitSDK.SplashKit;

OpenWindow("Create Animation Example", 800, 600);

// Load the animation script
var script = LoadAnimationScript("explosion", "explosion.txt");

// Create an animation from the script
var anim = CreateAnimation(script, "Explosion");

// Display animation information
ClearScreen(ColorWhite());
DrawText("Animation Created Successfully!", ColorGreen(), 280, 200);
DrawText("Animation Name: Explosion", ColorBlack(), 260, 250);
DrawText($"Current Cell: {AnimationCurrentCell(anim)}", ColorBlue(), 300, 300);
DrawText($"Animation Ended: {(AnimationEnded(anim) ? "Yes" : "No")}", ColorPurple(), 300, 350);
DrawText($"Frame Time: {AnimationFrameTime(anim)}", ColorOrange(), 300, 400);
RefreshScreen();

Delay(5000);

// Free resources
FreeAnimation(anim);
FreeAnimationScript(script);

CloseAllWindows();
